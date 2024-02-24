using System.Numerics;
using System.Text;
using Veldrid;
using Veldrid.SPIRV;

namespace Example;
public static class MeshPrimitives
{
    private static readonly Pipeline pipeline;
    static MeshPrimitives()
    {
        VertexLayoutDescription vertexLayout = new(new VertexElementDescription("Position", VertexElementSemantic.Position, VertexElementFormat.Float3));
        ShaderDescription vertexShaderDesc = new(
            ShaderStages.Vertex,
            Encoding.UTF8.GetBytes(@"
                #version 450

                layout(set = 0, binding = 0) uniform ProjectionMatrixBuffer
                { mat4 View; };

                layout(set = 0, binding = 1) uniform ObjectMatrixBuffer
                { mat4 Obj; };

                layout(location = 0) in vec3 Position;

                layout(location = 0) out vec4 fsin_Color;

                void main()
                {
                    gl_Position = View * Obj * vec4(Position, 1);
                    fsin_Color = vec4(Position, 0);
                }"),
            "main");
        ShaderDescription fragmentShaderDesc = new(
            ShaderStages.Fragment,
            Encoding.UTF8.GetBytes(@"
                #version 450

                layout(location = 0) in vec4 fsin_Color;

                layout(location = 0) out vec4 fsout_Color;

                void main()
                {
                    fsout_Color = fsin_Color;
                }"),
            "main");

        GraphicsDevice graphicsDevice = Program.graphicsDevice;
        ResourceFactory factory = graphicsDevice.ResourceFactory;

        Shader[] shaders = factory.CreateFromSpirv(vertexShaderDesc, fragmentShaderDesc);

        GraphicsPipelineDescription pipelineDescription = new()
        {
            BlendState = BlendStateDescription.SingleOverrideBlend,
            DepthStencilState = new()
            {
                DepthTestEnabled = true,
                DepthWriteEnabled = true,
                DepthComparison = ComparisonKind.Less,
                StencilTestEnabled = false,
            },
            RasterizerState = new()
            {
                CullMode = FaceCullMode.None,
                FillMode = PolygonFillMode.Solid,
                FrontFace = FrontFace.Clockwise,
                DepthClipEnabled = true,
                ScissorTestEnabled = false,
            },
            PrimitiveTopology = PrimitiveTopology.TriangleList,
            ResourceLayouts = new ResourceLayout[] { Program.ProjectionMatrixResourceLayout },
            ShaderSet = new()
            {
                VertexLayouts = [vertexLayout],
                Shaders = shaders,
                Specializations = null,
            },
            Outputs = Program.swapchainDesc,
        };
        pipeline = factory.CreateGraphicsPipeline(pipelineDescription);
        Program.disposables.Add(pipeline);
    }
    public static readonly MeshPrimitive cube = new(
        [
            new(0,0,0), new(0,0,1),
            new(0,1,0), new(0,1,1),
            new(1,0,0), new(1,0,1),
            new(1,1,0), new(1,1,1),
        ],
        [
            0,2,1, 1,2,3,
            4,5,6, 5,7,6,
            0,1,4, 1,5,4,
            1,3,5, 7,5,3,
            0,4,2, 2,4,6,
            2,6,3, 3,6,7,
        ]);
    public static readonly MeshPrimitive quad = new(
        [
            new(0,0,0), new(0,1,0),
            new(1,0,0), new(1,1,0),
        ],
        [
            0, 1, 2, 1, 3, 2
        ]);
    public static readonly MeshPrimitive tetrahedron = new(
        [
            new(0,0,0), new(0,0,1),
            new(0,1,0), new(0,1,1),
        ],
        [
            0, 1, 2,
            0, 2, 3,
            0, 3, 0,
            1, 2, 3,
        ]);
    public class MeshPrimitive
    {
        private readonly DeviceBuffer vertexBuffer;
        private readonly DeviceBuffer indexBuffer;
        private readonly uint indexCount;
        public MeshPrimitive(Vector3[] vertices, ushort[] indicies)
        {
            GraphicsDevice graphicsDevice = Program.graphicsDevice;
            ResourceFactory factory = graphicsDevice.ResourceFactory;

            indexCount = (uint)indicies.Length;

            vertexBuffer = factory.CreateBuffer(new BufferDescription((uint)(vertices.Length * sizeof(float) * 3), BufferUsage.VertexBuffer));
            indexBuffer = factory.CreateBuffer(new BufferDescription((uint)(indicies.Length * sizeof(ushort)), BufferUsage.IndexBuffer));
            using CommandList cl = factory.CreateCommandList();
            cl.Begin();
            cl.UpdateBuffer(vertexBuffer, 0, vertices);
            cl.UpdateBuffer(indexBuffer, 0, indicies);
            cl.End();
            graphicsDevice.SubmitCommands(cl);
            graphicsDevice.WaitForIdle();
            cl.Dispose();
            Program.disposables.Add(vertexBuffer);
            Program.disposables.Add(indexBuffer);
        }
        public void Draw(Matrix4x4 matrix)
        {
            Program.commandList.SetPipeline(pipeline);
            Program.commandList.UpdateBuffer(Program.ObjectMatrixBuffer, 0, matrix);
            Program.commandList.SetGraphicsResourceSet(0, Program.ProjectionMatrixResourceSet);
            Program.commandList.SetVertexBuffer(0, vertexBuffer);
            Program.commandList.SetIndexBuffer(indexBuffer, IndexFormat.UInt16);
            Program.commandList.DrawIndexed(indexCount, 1, 0, 0, 0);
        }
    }
}