using AviaTicketSystem;
Console.WriteLine("Sehifeden hansi menyu setrini secdiyinizi daxil edin:");
string menyu=Console.ReadLine();

switch (menyu)
{
    case Registration:
        SuperAdmin superadmin = new AviaTicketSystem.SuperAdmin();
        break;
    case TicketOrder:
        User user = new User();
        user.UserOrderTicket=Russia,Moscow,9:00;
        Console.WriteLine(user.UserOrderTicket);
        break;
     case TicketBack;
        SuperAdmin superadmin = new AviaTicketSystem.SuperAdmin();
        superadmin.Balanse();
        break;


}
