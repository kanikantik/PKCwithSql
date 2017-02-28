using PKCDashboard.Web;
using PKCDashboard.Web.Controllers;
using PKCDashboard.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace PKCDashboard.UnitTest
{
    /// <summary>
    /// AccountControllerTests class
    /// </summary>
    [TestClass]
    public class AccountControllerTests
    {
        /// <summary>
        /// The _mock signin manager
        /// </summary>
        Mock<ApplicationSignInManager> mockSigninManager;
        /// <summary>
        /// The _mock user manager
        /// </summary>
        Mock<ApplicationUserManager> mockUserManager;
        /// <summary>
        /// The account controller
        /// </summary>
        AccountController accountController;
        /// <summary>
        /// The _mock user store
        /// </summary>
        Mock<IUserStore<ApplicationUser>> mockUserStore;
        /// <summary>
        /// The _mockauthentication manager
        /// </summary>
        Mock<IAuthenticationManager> mockauthenticationManager;
        /// <summary>
        /// Tests the initialize.
        /// </summary>
        public AccountControllerTests()
        {
            mockUserStore = new Mock<IUserStore<ApplicationUser>>();
            mockauthenticationManager = new Mock<IAuthenticationManager>();
            mockUserManager = new Mock<ApplicationUserManager>(mockUserStore.Object);
            mockSigninManager = new Mock<ApplicationSignInManager>(mockUserManager.Object, mockauthenticationManager.Object);
            accountController = new AccountController(mockUserManager.Object, mockSigninManager.Object);
        }

        /// <summary>
        /// Accounts the controller_ login.
        /// </summary>
        [TestMethod]
        public void AccountController_Login()
        {
            string returnUrl = "Account Controller";
            var result = accountController.Login(returnUrl);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ login_task.
        /// </summary>
        [TestMethod]
        public void AccountController_Login_task()
        {
            LoginViewModel model = new LoginViewModel();
            string returnUrl = "accounts";
            var result = accountController.Login(model, returnUrl);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ verify code.
        /// </summary>
        [TestMethod]
        public void AccountController_VerifyCode()
        {
            string provider = "test";
            string returnUrl = "test";
            bool rememberMe = true;
            VerifyCodeViewModel viewModel = new VerifyCodeViewModel() { Code = "test", ReturnUrl = "test", Provider = "test", RememberMe = true };
            var result = accountController.VerifyCode(provider, returnUrl, rememberMe);
            var resultViewModel = accountController.VerifyCode(viewModel);
            Assert.IsNotNull(result);
            Assert.IsNotNull(resultViewModel);
        }

        /// <summary>
        /// Accounts the controller_ register.
        /// </summary>
        [TestMethod]
        public void AccountController_Register()
        {
            RegisterViewModel model = new RegisterViewModel() { ConfirmPassword = "test", Email = "test", Password = "test" };
            var result = accountController.Register(model);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ confirm email.
        /// </summary>
        [TestMethod]
        public void AccountController_ConfirmEmail()
        {
            string userId = "test";
            string code = "test";
            string userId_new = null;
            string code_new = null;
            var result = accountController.ConfirmEmail(userId, code);
            var result_new = accountController.ConfirmEmail(userId_new, code_new);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result_new);
        }

        /// <summary>
        /// Accounts the controller_ forgot password.
        /// </summary>
        [TestMethod]
        public void AccountController_ForgotPassword()
        {
            ForgotPasswordViewModel model = new ForgotPasswordViewModel() { Email = "abc@gmail.com" };
            var result = accountController.ForgotPassword();
            var result_new = accountController.ForgotPassword(model);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result_new);
        }

        /// <summary>
        /// Accounts the controller_ forgot password confirmation.
        /// </summary>
        [TestMethod]
        public void AccountController_ForgotPasswordConfirmation()
        {
            var result = accountController.ForgotPasswordConfirmation();
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ reset password.
        /// </summary>
        [TestMethod]
        public void AccountController_ResetPassword()
        {
            string code = "test";
            ResetPasswordViewModel model = new ResetPasswordViewModel() { Code = "test", ConfirmPassword = "test", Email = "abc@gmail.com", Password = "test" };
            var result = accountController.ResetPassword(code);
            var result_new = accountController.ResetPassword(model);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ reset password confirmation.
        /// </summary>
        [TestMethod]
        public void AccountController_ResetPasswordConfirmation()
        {
            var result = accountController.ResetPasswordConfirmation();
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ send code.
        /// </summary>
        [TestMethod]
        public void AccountController_SendCode()
        {
            string returnUrl = "test";
            bool rememberMe = true;
            SendCodeViewModel model = new SendCodeViewModel() { Providers = null, RememberMe = true, ReturnUrl = "test", SelectedProvider = "test" };
            var result = accountController.SendCode(returnUrl, rememberMe);
            var result_new = accountController.SendCode(model);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result_new);
        }

        /// <summary>
        /// Accounts the controller_ external login callback.
        /// </summary>
        [TestMethod]
        public void AccountController_ExternalLoginCallback()
        {
            string returnUrl = "test";
            var result = accountController.ExternalLoginCallback(returnUrl);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ external login confirmation.
        /// </summary>
        [TestMethod]
        public void AccountController_ExternalLoginConfirmation()
        {
            ExternalLoginConfirmationViewModel model = new ExternalLoginConfirmationViewModel() { Email = "abc@gmail.com" };
            string returnUrl = "test";
            var result = accountController.ExternalLoginConfirmation(model, returnUrl);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Accounts the controller_ external login failure.
        /// </summary>
        [TestMethod]
        public void AccountController_ExternalLoginFailure()
        {
            var result = accountController.ExternalLoginFailure();
            Assert.IsNotNull(result);
        }
    }
}
