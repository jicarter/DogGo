using System;
using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
    }
    public class ProfileViewModel
    {
        public Owner Owner { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<Dog> Dogs { get; set; }
    }
    public class OwnerFormViewModel
    {
        public Owner Owner { get; set; }
        public List<Neighborhood> Neighborhoods { get; set; }
    }
}