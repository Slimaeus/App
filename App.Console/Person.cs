namespace App.Console;

public class Person<THeight>
{
    public Person(IWeapon weapon)
    {
        Weapon = weapon;
    }
    public string? Name { get; set; }
    public int Age { get; set; }
    public THeight Height { get; set; }
    public IWeapon Weapon { get; set; }
}
