namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // criar uma variavel de contexto do banco de dados
        private UsuarioContext _context;

        // ao carregar a tela
        public Form1()
        {
            InitializeComponent();
            // instanciei um objeto do contexto
            _context = new UsuarioContext();
            // garantir que a base de dados sera criada
            _context.Database.EnsureCreated();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
    
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Nome = txtNome.Text,

            };
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            MessageBox.Show("usuario salvo com sucesso");
            LimparCampos();
        }





        private void LimparCampos()
        {
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;   
            txtNome.Text = string.Empty;
            txtNome.Focus();
        }
    }
}
