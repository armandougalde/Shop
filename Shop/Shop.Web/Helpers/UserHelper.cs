﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shop.Web.Data.Entities;
using Shop.Web.Helpers;
using Shop.Web.Models;

public class UserHelper : IUserHelper
{
    private readonly UserManager<User> userManager;
    private readonly SignInManager<User> signInManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public UserHelper(
        UserManager<User> userManager, 
        SignInManager<User>signInManager,
        RoleManager<IdentityRole>roleManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
        this.roleManager = roleManager;
    }

    public async Task<IdentityResult> AddUserAsync(User user, string password)
    {
        return await this.userManager.CreateAsync(user, password);
    }

    public async Task AddUserToRoleAsync(User user, string roleName)
    {
        await this.userManager.AddToRoleAsync(user, roleName);
    }

    public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
    {
        return await this.userManager.ChangePasswordAsync(user, oldPassword, newPassword);


    }
    //ss

    public async Task CheckRoleAsync(string roleName )
    {
        var roleExists = await this.roleManager.RoleExistsAsync(roleName);
        if (!roleExists)
        {
            await this.roleManager.CreateAsync(new IdentityRole
            {
                Name = roleName
            });
        }

    }

    public Task ConfirmEmailAsync(User user, object token)
    {
        throw new System.NotImplementedException();
    }

    public Task GenerateEmailConfirmationTokenAsync(User user)
    {
        throw new System.NotImplementedException();
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
         return await this.userManager.FindByEmailAsync(email);
         
    }

    public async Task<bool> IsUserInRoleAsync(User user, string roleName)
    {
        return await this.userManager.IsInRoleAsync(user,roleName);
    }

    public async Task<SignInResult> LogingAsync(LoginViewModel model)
    {
        return await this.signInManager.PasswordSignInAsync(model.Username,model.Password,model.RememberMe,false);
    }

    public async Task LogoutAsync()
    {
        await this.signInManager.SignOutAsync();
    }

    public async Task<IdentityResult> UpdateUserAsync(User user)
    {
        return await this.userManager.UpdateAsync(user);

    }

    public async Task<SignInResult> ValidatePasswordAsync(User user, string password)
    {
        return await this.signInManager.CheckPasswordSignInAsync(
            user,
            password,
            false);
    }

    Task<bool> IUserHelper.IsUserInRoleAsync(User user, string roleName)
    {
        throw new System.NotImplementedException();
    }
}
