using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using blog_project.Repositories;

namespace blog_project.Screens.UserRoleScreens
{
    public class AssociateUserRoleScreen
    {
        private readonly UserRepository _userRepository;

        public AssociateUserRoleScreen(UserRepository userRepository)
            => _userRepository = userRepository;


        public UserRepository Get_userRepository()
            => _userRepository;


        public void Display()
        {
            Console.WriteLine("Associação usuário com perfil");
            Console.WriteLine("------------------------------");

            // Prompt the user to enter a userId
            int userId = PromptUserForUserId();

            // Display a list of available roles
            var roles = GetAvailableRoles();
            DisplayRoles(roles);

            // Allow the user to select one or more roles
            var selectedRoleIds = PromptUserForRoleSelection(roles);
            _userRepository.AssociateUserRoleScreen(userId, selectedRoleIds);

            Console.WriteLine("User roles updated successfully.");
        }

        private int PromptUserForUserId()
        {
            Console.Write("Enter user ID: ");
            return int.Parse(Console.ReadLine());
        }

        private List<Role> GetAvailableRoles()
        {
            // Implement logic to retrieve available roles from the database or other sources
            return new List<Role>
            {
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Manager" },
                new Role { Id = 3, Name = "User" }
            };
        }

        private void DisplayRoles(List<Role> roles)
        {
            Console.WriteLine("Available roles:");
            foreach (var role in roles)
            {
                Console.WriteLine($"{role.Id}. {role.Name}");
            }
        }

        private List<int> PromptUserForRoleSelection(List<Role> roles)
        {
            var selectedRoleIds = new List<int>();
            while (true)
            {
                Console.Write("Enter role ID (or 'q' to finish): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "q")
                    break;

                if (int.TryParse(input, out int roleId) && roles.Any(r => r.Id == roleId))
                {
                    selectedRoleIds.Add(roleId);
                }
                else
                {
                    Console.WriteLine("Invalid role ID. Please try again.");
                }
            }
            return selectedRoleIds;
        }
    }
}