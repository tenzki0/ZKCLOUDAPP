using Microsoft.AspNetCore.Mvc;

namespace ZKCLOUDAPP
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _userService.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(nameof(user.Login), nameof(user.Password), nameof(user.FirstName), nameof(user.LastName), nameof(user.Email), nameof(user.PhoneNumber))] User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            await _userService.AddAsync(user);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (await _userService.GetByAsync(id) is not User user)
            {
                return View("Użytkownik nie znaleziony");
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind(nameof(user.Login), nameof(user.FirstName), nameof(user.LastName), nameof(user.Email), nameof(user.PhoneNumber))] User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            await _userService.UpdateAsync(id, user);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await _userService.GetByAsync(id) is not User user)
            {
                return View("Użytkownik nie znaleziony");
            }

            return View(user);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await _userService.GetByAsync(id) is not User user)
            {
                return View("Użytkownik nie znaleziony");
            }

            await _userService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
