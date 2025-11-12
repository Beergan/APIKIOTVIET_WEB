using PetaPoco;
using System;
using System.ComponentModel.DataAnnotations.Schema;

public class VM_Customer : VM_Base
{
    public string Username { get; set; }

    public Boolean Active { get; set; }

    public string DisplayName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

	public int City { get; set; }

    public int Ward { get; set; }

    public int Commune { get; set; }
}