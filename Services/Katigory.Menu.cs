using models;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Modul_2.Services;

public partial class Katigory
{
    private List<Menu> menu = new List<Menu>();
    
    public void GetMenu()
    {
        ListFastfood();
        ListTaomlar();
        ListIchimlik();
        ListTaomlar();
    }
}
