namespace PresentationLayer
{
    public class LoginHandler
    {
        private readonly OutputHandler _outputHandler=new OutputHandler();
        private readonly InputHandler _inputHandler=new InputHandler();
        public readonly LogicLayer.LoginHandler _loginHandler=new LogicLayer.LoginHandler();

        public void StartLoginProcess()
        {
            while (true)
            {
                string username = null;
                string password = null;

                while (username == null)
                {
                    _outputHandler.Output("To log in please enter username:");
                    username = _inputHandler.ReadInput();
                }

                while (password == null)
                {
                    _outputHandler.Output("To log in please enter password:");
                    password = _inputHandler.ReadInput();
                }

                if (_loginHandler.checkUserAndPassword(username, password))
                {
                    _outputHandler.Output("You are logged in [NOT YET IMPLEMENTED]");
                }
                else
                {
                    _outputHandler.Output("Incorrect username or password, please try again.");
                    continue;
                }
                break;
            }
        }
    }
}