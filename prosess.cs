using System.ComponentModel.DataAnnotations;

public class products
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int count { get; set; }
    public int price { get; set; }
    public int status = 0;


    List<products> list = new List<products>();

    public void mainmenu()
    {
        System.Console.WriteLine("**************");
        System.Console.WriteLine("Please choose:");
        System.Console.WriteLine("Admin=======>1");
        System.Console.WriteLine("User========>2");
        System.Console.WriteLine("Exit========>3");
        System.Console.WriteLine("**************");

        choose();
    }

    public void choose()
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                admin();
                break;
            case 2:
                user();
                break;
            case 3:
                exit();
                break;
        }

    }

    public void user()
    {
        System.Console.WriteLine("*********");
        System.Console.WriteLine("Add====>1");
        System.Console.WriteLine("Status=>2");
        int d;
        d = Convert.ToInt32(Console.ReadLine());

        switch (d)
        {
            case 1:
                Add();
                break;
            case 2:
                statu();
                break;
        }


    }

    public void Add()
    {


        int y;
        do
        {
            products p = new products();
            System.Console.WriteLine("Please enter prouduct id :");
            p.Id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter product name:");
            p.Name = Console.ReadLine();
            System.Console.WriteLine("Please enter product count:");
            p.count = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter product price:");
            p.price = Convert.ToInt32(Console.ReadLine());
            list.Add(p);
            System.Console.WriteLine("************************");
            System.Console.WriteLine("Do you want to continue?");
            System.Console.WriteLine("Yes=====>1*****No=====>2");
            y = Convert.ToInt32(Console.ReadLine());

        } while (y == 1);

        mainmenu();
    }

    public void admin()
    {
        int pass;
        do
        {
            System.Console.WriteLine("*********************");
            System.Console.WriteLine("Please enter password:");
            pass = Convert.ToInt32(Console.ReadLine());

        } while (pass != 1234);

        adminmain();
    }

    public void adminmain()
    {
        System.Console.WriteLine("************************");
        System.Console.WriteLine("Accept and reject=====>1");
        System.Console.WriteLine("***********Status=====>2");
        System.Console.WriteLine("************************");
        int d;
        d = Convert.ToInt32(Console.ReadLine());

        switch (d)
        {
            case 1:
                acANDre();
                break;
            case 2:
                statu();
                break;
        }

    }
    public void acANDre()
    {
        foreach (var item in list)
        {
            if (item.status == 0)
            {
                System.Console.WriteLine("No:" + item.Id + "***" + "Name:" + item.Name
                                       + "***" + "Count:" + item.count + "***" + "Price:" + item.price);
            }



            System.Console.WriteLine("accept===>1****reject===>2***waiting===>3");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                item.status = 1;
            }
            else if (a == 2)
            {
                item.status = -1;
            }
            else if (a == 3)
            {
                item.status = 0;
            }

        }
        mainmenu();

    }

    public void statu()
    {
        foreach (var item in list)
        {
            if (item.status == 0)
            {
                System.Console.WriteLine("Waiting");
                System.Console.WriteLine("NO:" + item.Id + "***" + "Name:" + item.Name
                                        + "***" + "Count:" + item.count + "***" + "Price:" + item.price);
            }
            if (item.status == 1)
            {
                System.Console.WriteLine("Registered");
                System.Console.WriteLine("NO:" + item.Id + "***" + "Name:" + item.Name
                                        + "***" + "Count:" + item.count + "***" + "Price:" + item.price);
            }
            if (item.status == -1)
            {
                System.Console.WriteLine("Not-Registered");
                System.Console.WriteLine("NO:" + item.Id + "***" + "Name:" + item.Name
                                        + "***" + "Count:" + item.count + "***" + "Price:" + item.price);
            }

        }
        mainmenu();
    }

    public void exit()
    {
        System.Console.WriteLine("exit");
    }

}