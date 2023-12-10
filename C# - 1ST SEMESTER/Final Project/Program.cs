using static Store_IgorSteffen.Program;

namespace Store_IgorSteffen
{
    internal class Program
    {
        #region VARIABLES
        public static int mainOption = 0;
        public static int signInOption = 0;
        public static int employeeOption = 0;
        public static int clientOption = 0;
        public static string defaultPasswordEmployee = "";
        public static string defaultPasswordEmployeeConfirmation = "";
        public static string defaultLoginEmployee = "";
        public static bool isLoggedIn = false;
        public static bool isLoggedInClient = false;
        public static int purchaseCount = 0;
        public static int productCount = 0;
        public static int clientCount = 0;
        public static int modifyProductOption = 0;
        public static string employeeName = "IGOR STEFFEN";
        static bool hasInitializedDefaults = false;
        #endregion

        #region CONSTANTS
        public const int MIN_ID_VALUE_PRODUCT = 100000;
        public const int MAX_ID_VALUE_PRODUCT = 999999;
        public const int MIN_ID_VALUE_CLIENT = 1;
        public const int MAX_ID_VALUE_CLIENT = 10;
        public const int PASSWORD_LENGTH = 10;
        public const int MAX_CLIENT_CAPACITY = 10;
        public const int MAX_PRODUCT_CAPACITY = 999999;
        #endregion

        #region ARRAYS        
        public static Client[] clients = new Client[MAX_CLIENT_CAPACITY];
        public static Product[] products = new Product[MAX_PRODUCT_CAPACITY];
        public static Purchase[] purchases = new Purchase[MAX_CLIENT_CAPACITY];
        #endregion        

        #region STRUCTS
        public struct Client
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string Password;
            public string PasswordConfirmation;

            // Constructor
            public Client(int id, string firstName, string lastName, string password, string passwordConfirmation)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Password = password;
                PasswordConfirmation = passwordConfirmation;
            }
        }
        public struct Product
        {
            public int Id;
            public string Name;
            public double UnitPrice;
            public int QuantityAvailable;

            //Constructor
            public Product(int id, string name, double unitPrice, int quantityAvailable)
            {
                Id = id;
                Name = name;
                UnitPrice = unitPrice;
                QuantityAvailable = quantityAvailable;
            }
        }
        public struct Purchase
        {
            public Client Client;
            public Product[] Products;
            public double Subtotal;
            public double Taxes;
            public double TotalPrice;

            //Constructor
            public Purchase(Client client, Product[] products, double subtotal, double taxes, double totalPrice)
            {
                Client = client;
                Products = products;
                Subtotal = subtotal;
                Taxes = taxes;
                TotalPrice = totalPrice;
            }
        }
        #endregion

        #region EXTRA FUNCTIONS
        static void ShowMainMenu()
        {            
            Console.Clear();
            Console.WriteLine("S T E F F E N ' S    S T O R E    S Y S T E M\n");
            GetChoiceMainMenu(mainMenu);
            Console.WriteLine();
            Console.Write("SELECT AN OPTION: ");
            while (!Int32.TryParse(Console.ReadLine(), out mainOption) || mainOption < 1 || mainOption > 2)
            {
                Console.Write("**OPTION DOESN'T EXIST**\nTRY AGAIN: ");
            }
            switch (mainOption)
            {
                case 1:
                    MainMenuOption1();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
        static void MainMenuOption1()
        {
            Console.Clear();
            Console.WriteLine("SIGN IN MENU\n");
            GetChoiceSignInMenu(signInMenu);
            Console.Write("\nSELECT AN OPTION: ");
            while (!Int32.TryParse(Console.ReadLine(), out signInOption) || signInOption < 1 || signInOption > 3)
            {
                Console.Write("**OPTION DOESN'T EXIST**\nTRY AGAIN: ");
            }
            switch (signInOption)
            {
                case 1:
                    SignInMenuOption1();
                    break;
                case 2:
                    SignInMenuOption2();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
        static void SignInMenuOption1()
        {            
            defaultLoginEmployee = "";
            defaultPasswordEmployee = "";
            isLoggedIn = false;

            if (!hasInitializedDefaults)
            {
                InitializeDefaultProducts();
                InitializeDefaultClients();
                hasInitializedDefaults = true;
            }
            while (!isLoggedIn)
            {
                Console.Clear();
                EmployeeLogin();
                Console.Clear();
                DateTime currentDate = DateTime.Now;
                Console.WriteLine($"EMPLOYEE MENU\t\t\t\t\t\t\tEMPLOYEE: {employeeName}\t\t" + currentDate.ToString("dd-MM-yyyy HH:mm:ss") + "\n");                
                GetChoiceEmployeeMenu(employeeMenu);
                Console.Write("\nSELECT AN OPTION: ");
                while (!Int32.TryParse(Console.ReadLine(), out employeeOption) || employeeOption < 1 || employeeOption > 10)
                {
                    Console.Write("**OPTION DOESN'T EXIST**\nTRY AGAIN: ");
                }
                switch (employeeOption)
                {
                    case 1:
                        EmployeeMenuOption1();
                        break;
                    case 2:
                        EmployeeMenuOption2();
                        break;
                    case 3:
                        EmployeeMenuOption3();
                        break;
                    case 4:
                        EmployeeMenuOption4();
                        break;
                    case 5:
                        EmployeeMenuOption5();
                        break;
                    case 6:
                        EmployeeMenuOption6();
                        break;
                    case 7:
                        EmployeeMenuOption7();
                        break;
                    case 8:
                        EmployeeMenuOption8();
                        break;
                    case 9:
                        EmployeeMenuOption9();
                        break;
                    case 10:
                        EmployeeMenuOption10();
                        break;
                }
            }
        }
        static void EmployeeMenuOption1()
        {
            Console.Clear();
            Console.WriteLine("CREATE PRODUCT\n");
            CreateProduct();
        }
        static void EmployeeMenuOption2()
        {
            Console.Clear();
            Console.WriteLine("MODIFY PRODUCT\n");
            ModifyProduct();
        }
        static void EmployeeMenuOption3()
        {
            Console.Clear();
            Console.WriteLine("DISPLAY PRODUCTS SORTED BY ID\n");
            DisplayProductsById();
            Console.ReadLine();
        }
        static void EmployeeMenuOption4()
        {
            Console.Clear();
            Console.WriteLine("CREATE CLIENT");
            CreateClient();
        }
        static void EmployeeMenuOption5()
        {
            Console.Clear();
            Console.WriteLine("MODIFY CLIENT\n");
            ModifyClient();
        }
        static void EmployeeMenuOption6()
        {
            Console.Clear();
            Console.WriteLine("DISPLAY CLIENTS SORTED BY ID\n");
            DisplayClientsById();
            Console.ReadLine();
        }
        static void EmployeeMenuOption7()
        {
            Console.Clear();
            Console.WriteLine("SELL PRODUCTS\n");
            if (productCount == 0)
            {
                Console.WriteLine("**NO PRODUCTS AVAILABLE FOR SALE");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("AVAILABLE PRODUCTS:\n");
            DisplayProductsById();
            Console.WriteLine();
            DisplayClients();
            Console.WriteLine();

            Console.Write("\nPRODUCT ID: ");
            int productIdToSell = ReadInteger(MIN_ID_VALUE_PRODUCT, MAX_ID_VALUE_PRODUCT);

            int productIndex = FindProductIndexById(productIdToSell);
            if (productIndex != -1)
            {
                if (products[productIndex].QuantityAvailable > 0)
                {
                    Console.Write("QTY: ");
                    int quantityToSell = ReadInteger(1, products[productIndex].QuantityAvailable);

                    double subTotalPrice = quantityToSell * products[productIndex].UnitPrice;
                    double taxes = subTotalPrice * 0.15;
                    double totalPrice = subTotalPrice + taxes;

                    products[productIndex].QuantityAvailable -= quantityToSell;

                    Console.Write("CLIENT ID: ");
                    int clientIdForSale = ReadInteger(MIN_ID_VALUE_CLIENT, MAX_ID_VALUE_CLIENT);

                    Client selectedClient = GetClientById(clientIdForSale);
                    if (selectedClient.Id != 0)
                    {
                        RecordSale(selectedClient, products[productIndex], quantityToSell, subTotalPrice, taxes, totalPrice);
                        Console.WriteLine($"\nTOTAL PRICE: ${totalPrice}\n**PRODUCT SOLD**");
                    }
                    else
                    {
                        Console.WriteLine("**CLIENT ID DOES NOT EXIST**");
                    }
                }
                else
                {
                    Console.WriteLine("**PRODUCT OUT OF STOCK**");
                }
            }
            else
            {
                Console.WriteLine("**PRODUCT NOT FOUND**");
            }
            Console.ReadLine();
        }
        static void EmployeeMenuOption8()
        {
            Console.Clear();
            Console.WriteLine("DISPLAY SALES\n");
            AllSales();
            Console.ReadLine();
        }
        static void EmployeeMenuOption9()
        {
            Console.Clear();
            Console.WriteLine("DISPLAY TOTAL OF SALES\n");
            TotalSales();
            Console.ReadLine();
        }
        static void EmployeeMenuOption10()
        {
            Console.Clear();
            isLoggedIn = true;
        }
        static void SignInMenuOption2()
        {
            isLoggedInClient = false;
            Client client;
            while (true)
            {
                Console.Clear();
                if (IsCapsLockOn())
                {
                    Console.WriteLine("**CAPS LOCK ACTIVATED**\n");
                }
                Console.Write("ID: ");
                int clientId = ReadInteger(MIN_ID_VALUE_CLIENT, MAX_ID_VALUE_CLIENT);
                Console.Write("PASSWORD: ");
                string password = ReadPassword();
                Console.Write("\nPASSWORD CONFIRMATION: ");
                string passwordConfirmation = ReadPassword();

                if (AuthenticateClient(clientId, password, passwordConfirmation, out client))
                {
                    isLoggedInClient = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\n**AUTHENTICATION FAILED. PLEASE TRY AGAIN.**");
                    Thread.Sleep(1000);
                    return;
                }
            }
            if (isLoggedInClient)
            {
                string clientName = client.FirstName + " " + client.LastName;
                while (isLoggedInClient)
                {
                    Console.Clear();
                    DateTime currentDate = DateTime.Now;
                    Console.WriteLine($"CLIENT MENU\t\t\t\t\t\t\tCLIENT: {clientName}\t\t" + currentDate.ToString("dd-MM-yyyy HH:mm:ss") + "\n");
                    GetChoiceClientMenu(clientMenu);
                    Console.Write("\nSELECT AN OPTION: ");

                    while (!Int32.TryParse(Console.ReadLine(), out clientOption) || clientOption < 1 || clientOption > 3)
                    {
                        Console.Write("**OPTION DOESN'T EXIST**\nTRY AGAIN: ");
                    }

                    switch (clientOption)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("DISPLAY ALL PRODUCTS\n");
                            DisplayProductsById();
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("PURCHASES MADE\n");

                            int clientIdToDisplayPurchases = client.Id;
                            Client selectedClientForPurchases = GetClientById(clientIdToDisplayPurchases);

                            if (selectedClientForPurchases.Id != 0)
                            {
                                DisplayPurchasesByClient(selectedClientForPurchases);
                            }
                            else
                            {
                                Console.WriteLine("**CLIENT ID DOES NOT EXIST**");
                                Thread.Sleep(1000);
                            }
                            break;
                        case 3:
                            ClientMenuOption3();
                            break;
                    }
                }
            }            
        }
        static void ClientMenuOption3()
        {
            Console.Clear();
            isLoggedInClient = false;
        }
        static void InitializeDefaultProducts()
        {
            products[0] = new Product(100001, "Laptop", 1200.0, 30);
            products[1] = new Product(100002, "Smartphone", 800.0, 50);
            products[2] = new Product(100003, "Headphones", 100.0, 100);
            products[3] = new Product(100004, "Wireless Mouse", 25.0, 75);
            products[4] = new Product(100005, "External Hard Drive", 150.0, 20);

            productCount = 5;
        }
        static void InitializeDefaultClients()
        {
            clients[0] = new Client(1, "IGOR", "STEFFEN", "12345678", "12345678");
            clientCount = 1;
        }
        static double ReadDouble()
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value) || value < 0)
            {
                Console.Write("**ONLY POSITIVE NUMBERS**: $");
            }
            return value;
        }
        static int ReadInteger(int min, int max)
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.WriteLine($"\nVALUE MUST BE BETWEEN {min} AND {max}\n");
                Console.Write("TYPE ANOTHER: ");
            }
            return value;
        }
        static int FindProductIndexById(int productId)
        {
            foreach (var product in products)
            {
                if (product.Id == productId)
                {
                    return Array.IndexOf(products, product);
                }
            }

            return -1;
        }
        static void GetChoiceMainMenu(string[] mainMenu)
        {
            for (int i = 0; i < mainMenu.Length; i++)
            {
                Console.WriteLine(mainMenu[i]);
            }
        }
        static void GetChoiceSignInMenu(string[] signInMenu)
        {
            for (int i = 0; i < signInMenu.Length; i++)
            {
                Console.WriteLine(signInMenu[i]);
            }
        }
        static void EmployeeLogin()
        {
            while (defaultLoginEmployee != "111111" || defaultPasswordEmployee != "tester" || defaultPasswordEmployeeConfirmation != defaultPasswordEmployee)
            {
                defaultLoginEmployee = "111111";
                defaultPasswordEmployee = "tester";
                Console.WriteLine($"(TEST ID: {defaultLoginEmployee}  TEST PASSWORD: {defaultPasswordEmployee})\n");
                if (IsCapsLockOn())
                {
                    Console.WriteLine("**CAPS LOCK ACTIVATED**\n");
                }
                Console.Write("ID: ");
                defaultLoginEmployee = Console.ReadLine();
                Console.Write("PASSWORD: ");
                defaultPasswordEmployee = ReadPassword();
                Console.Write("\nPASSWORD CONFIRMATION: ");
                defaultPasswordEmployeeConfirmation = ReadPassword();
                if (defaultLoginEmployee != "111111")
                {
                    Console.WriteLine("\n\n**ID DOES NOT EXIST**");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                if (defaultPasswordEmployee != "tester")
                {
                    Console.WriteLine("\n\n**WRONG PASSWORD**");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                if (defaultPasswordEmployeeConfirmation != defaultPasswordEmployee)
                {
                    Console.WriteLine("\n\n**PASSWORDS DO NOT MATCH**");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
            }

        }
        static bool IsCapsLockOn()
        {
            return Console.CapsLock;
        }
        static bool AuthenticateClient(int clientId, string password, string passwordConfirmation, out Client authenticatedClient)
        {
            foreach (var client in clients)
            {
                if (client.Id == clientId)
                {
                    if (client.Password == password)
                    {
                        if (client.PasswordConfirmation == passwordConfirmation)
                        {
                            authenticatedClient = client; // Cliente autenticado com sucesso
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("\n**PASSWORDS DO NOT MATCH**");
                            Thread.Sleep(1000);
                            authenticatedClient = default;
                            return false; // Confirmação de senha incorreta
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n**WRONG PASSWORD**");
                        Thread.Sleep(1000);
                        authenticatedClient = default;
                        return false; // Senha incorreta                        
                    }
                }
            }

            Console.WriteLine("\n**CLIENT ID DOES NOT EXIST**");
            Thread.Sleep(1000);
            authenticatedClient = default;
            return false;
        }
        static void GetChoiceEmployeeMenu(string[] employeeMenu)
        {
            for (int i = 0; i < employeeMenu.Length; i++)
            {
                Console.WriteLine(employeeMenu[i]);
            }
        }
        static void CreateProduct()
        {
            if (productCount == MAX_PRODUCT_CAPACITY)
            {
                Console.WriteLine("**MAX PRODUCT CREATION CAPACITY REACHED**");
                return;
            }

            Console.Write($"NEW PRODUCT ID(FROM #{MIN_ID_VALUE_PRODUCT + productCount + 1} UP TO #{MAX_ID_VALUE_PRODUCT}): ");
            int productId = ReadUniqueProductId();

            Console.Write("NEW PRODUCT NAME: ");
            string productName = Console.ReadLine();

            Console.Write("UNIT PRICE: $");
            double unitPrice = ReadDouble();

            Console.Write("AVAILABLE QTY: ");
            int quantityAvailable = ReadInteger(0, int.MaxValue);

            products[productCount].Id = productId;
            products[productCount].Name = productName;
            products[productCount].UnitPrice = unitPrice;
            products[productCount].QuantityAvailable = quantityAvailable;

            productCount++;
            Console.WriteLine("\n**PRODUCT CREATED**");
            Thread.Sleep(1000);
        }
        static void ModifyProduct()
        {
            Console.WriteLine("1. BY PRODUCT ID");
            Console.WriteLine("2. BY PRODUCT NAME");
            Console.WriteLine("3. REMOVE PRODUCT BY ID");
            Console.WriteLine("4. REMOVE PRODUCT BY NAME");
            Console.WriteLine("5. RETURN TO MENU");
            Console.Write("\nSELECT AN OPTION: ");
            while (!Int32.TryParse(Console.ReadLine(), out modifyProductOption) || modifyProductOption < 1 || modifyProductOption > 5)
            {
                Console.Write("**OPTION DOESN'T EXIST**\nTRY AGAIN: ");
            }

            switch (modifyProductOption)
            {
                case 1:
                    ModifyProductById();                    
                    break;
                case 2:
                    ModifyProductByName();                    
                    break;
                case 3:
                    RemoveProductById();
                    break;
                case 4:
                    RemoveProductByName();
                    break;
                case 5:
                    return;
            }
        }
        static void ModifyProductById()
        {
            Console.Clear();
            DisplayProductsById();
            Console.Write("\nPRODUCT ID: ");
            int productIdToModify = ReadInteger(MIN_ID_VALUE_PRODUCT, MAX_ID_VALUE_PRODUCT);

            int productIndex = FindProductIndexById(productIdToModify);

            if (productIndex == -1)
            {
                Console.WriteLine($"**PRODUCT ID {productIdToModify} DOES NOT EXISTS**");
                return;
            }
            Console.WriteLine($"PRODUCT SELECTED: {products[productIndex].Id}: {products[productIndex].Name}");

            Console.Write("\nNEW PRODUCT NAME: ");
            products[productIndex].Name = Console.ReadLine();

            Console.Write("NEW UNIT PRICE: ");
            products[productIndex].UnitPrice = ReadDouble();

            Console.Write("NEW QUANTITY AVAILABLE: ");
            products[productIndex].QuantityAvailable = ReadInteger(0, int.MaxValue);

            Console.WriteLine("\n**PRODUCT MODIFIED**");
            Thread.Sleep(2000);
        }
        static void ModifyProductByName()
        {
            Console.Clear();
            DisplayProductsById();
            Console.Write("\nPRODUCT NAME: ");
            string productNameToModify = Console.ReadLine();

            int productIndex = FindProductIndexByName(productNameToModify);

            if (productIndex == -1)
            {
                Console.WriteLine($"\n**PRODUCT NAME '{productNameToModify}' DOES NOT EXISTS**");
                return;
            }

            Console.WriteLine($"PRODUCT SELECTED {products[productIndex].Id}: {products[productIndex].Name}");

            Console.Write("NEW PRODUCT NAME: ");
            products[productIndex].Name = Console.ReadLine();

            Console.Write("NEW UNIT PRICE: ");
            products[productIndex].UnitPrice = ReadDouble();

            Console.Write("NEW QUANTITY AVAILABLE: ");
            products[productIndex].QuantityAvailable = ReadInteger(0, int.MaxValue);

            Console.WriteLine("\n**PRODUCT MODIFIED**");
            Thread.Sleep(2000);
        }
        static void RemoveProductById()
        {
            Console.Clear();
            DisplayProductsById();
            Console.Write("\nPRODUCT ID TO REMOVE: ");
            int productIdToRemove = ReadInteger(MIN_ID_VALUE_PRODUCT, MAX_ID_VALUE_PRODUCT);

            int productIndex = FindProductIndexById(productIdToRemove);

            if (productIndex == -1)
            {
                Console.WriteLine($"\n**PRODUCT ID {productIdToRemove} DOES NOT EXIST**");
                return;
            }

            Console.WriteLine($"PRODUCT SELECTED {products[productIndex].Id}: {products[productIndex].Name}");

            Console.Write("\nARE YOU SURE YOU WANT TO REMOVE THIS PRODUCT? (Y/N): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToUpper() == "Y")
            {                
                for (int i = productIndex; i < productCount - 1; i++)
                {
                    products[i] = products[i + 1];
                }

                for (int i = productIndex; i < productCount - 1; i++)
                {
                    products[i].Id = i + 100001;
                }

                products[productCount - 1] = default;

                productCount--;

                Console.WriteLine("\n**PRODUCT REMOVED**");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("\n**PRODUCT NOT REMOVED**");
                Thread.Sleep(2000);
            }
        }
        static void RemoveProductByName()
        {
            Console.Clear();
            DisplayProductsById();
            Console.Write("\nPRODUCT NAME TO REMOVE: ");
            string productNameToRemove = Console.ReadLine();

            int productIndex = FindProductIndexByName(productNameToRemove);

            if (productIndex == -1)
            {
                Console.WriteLine($"\n**PRODUCT NAME '{productNameToRemove}' DOES NOT EXIST**");
                return;
            }

            Console.WriteLine($"PRODUCT SELECTED {products[productIndex].Id}: {products[productIndex].Name}");

            Console.Write("\nARE YOU SURE YOU WANT TO REMOVE THIS PRODUCT? (Y/N): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToUpper() == "Y")
            {
                for (int i = productIndex; i < productCount - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                products[productCount - 1] = default;

                productCount--;

                Console.WriteLine("\n**PRODUCT REMOVED**");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("\n**PRODUCT NOT REMOVED**");
                Thread.Sleep(2000);
            }
        }
        static void DisplayProductsById()
        {
            var sortedProducts = products.OrderBy(p => p.Id);
            Console.WriteLine("ID".PadRight(8) + "NAME".PadRight(25) + "PRICE".PadRight(10) + "QTY AVAILABLE");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var product in sortedProducts)
            {
                if (product.Id != 0)
                {
                    Console.WriteLine(
                product.Id.ToString().PadRight(8) +
                product.Name.PadRight(25) +
                $"${product.UnitPrice}".PadRight(10) +
                product.QuantityAvailable.ToString());
                }
            }
        }
        static void CreateClient()
        {
            if (clientCount == MAX_CLIENT_CAPACITY)
            {
                Console.WriteLine("**MAX CLIENT CREATION CAPACITY REACHED**");
            }

            Console.Write($"\nCLIENT ID(FROM #{MIN_ID_VALUE_CLIENT + clientCount} UP TO #{MAX_ID_VALUE_CLIENT}): ");
            int clientId = ReadUniqueClientId();

            Console.Write("CLIENT FIRST NAME: ");
            string firstName = Console.ReadLine();

            Console.Write("CLIENT LAST NAME: ");
            string lastName = Console.ReadLine();

            Console.Write("PASSWORD: ");
            string password = ReadPassword();

            Console.Write("\nPASSWORD CONFIRMATION: ");
            string passwordConfirmation = ReadPassword();

            clients[clientCount].Id = clientId;
            clients[clientCount].FirstName = firstName;
            clients[clientCount].LastName = lastName;
            clients[clientCount].Password = password;
            clients[clientCount].PasswordConfirmation = passwordConfirmation;
            clientCount++;
            Console.WriteLine("\n\n**CLIENT CREATED**");
            Thread.Sleep(1000);
        }
        static void ModifyClient()
        {
            DisplayClients();
            Console.Write("\nCLIENT ID: ");
            int clientIdToModify = ReadInteger(MIN_ID_VALUE_CLIENT, MAX_ID_VALUE_CLIENT);

            int clientIndex = Array.FindIndex(clients, c => c.Id == clientIdToModify);

            if (clientIndex == -1)
            {
                Console.WriteLine($"**CLIENT ID {clientIdToModify} DOES NOT EXIST**");
                return;
            }

            Console.WriteLine($"CLIENT SELECTED: {clients[clientIndex].Id}: {clients[clientIndex].FirstName} {clients[clientIndex].LastName}");

            Console.Write("\nNEW CLIENT FIRST NAME: ");
            clients[clientIndex].FirstName = Console.ReadLine();

            Console.Write("NEW CLIENT LAST NAME: ");
            clients[clientIndex].LastName = Console.ReadLine();

            Console.Write("NEW PASSWORD: ");
            clients[clientIndex].Password = ReadPassword();

            Console.Write("NEW PASSWORD CONFIRMATION: ");
            clients[clientIndex].PasswordConfirmation = ReadPassword();

            Console.WriteLine("**CLIENT MODIFIED**");
        }
        static void DisplayClientsById()
        {
            var sortedClients = clients.OrderBy(c => c.Id);
            Console.WriteLine("CLIENT ID".PadRight(12) + "CLIENT NAME".PadRight(40) + "PASSWORD");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var client in sortedClients)
            {
                if (client.Id != 0)
                {
                    Console.WriteLine(
                        client.Id.ToString().PadRight(12) +
                        $"{client.FirstName} {client.LastName}".PadRight(40) +
                        client.Password);
                }
            }
        }
        static void DisplayClients()
        {
            var sortedClients = clients.OrderBy(c => c.Id);
            Console.WriteLine("CLIENT ID".PadRight(12) + "FIRST NAME".PadRight(20) + "LAST NAME".PadRight(20));
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var client in sortedClients)
            {
                if (client.Id != 0)
                {
                    Console.WriteLine(
                        client.Id.ToString().PadRight(12) +
                        client.FirstName.PadRight(20) +
                        client.LastName.PadRight(20));
                }
            }
        }
        static Client GetClientById(int clientId)
        {
            foreach (var client in clients)
            {
                if (client.Id == clientId)
                {
                    return client;
                }
            }

            return new Client();
        }
        static int ReadUniqueProductId()
        {
            int productId = ReadInteger(MIN_ID_VALUE_PRODUCT, MAX_ID_VALUE_PRODUCT);

            while (ProductExists(productId))
            {
                Console.WriteLine("\n**PRODUCT ALREADY EXISTS. CREATE A DIFFERENT ID**\n");
                Console.Write("PRODUCT ID: ");
                productId = ReadInteger(MIN_ID_VALUE_PRODUCT, MAX_ID_VALUE_PRODUCT);
            }

            return productId;
        }
        static bool ProductExists(int productId)
        {
            foreach (var product in products)
            {
                if (product.Id == productId)
                {
                    return true;
                }
            }
            return false;
        }
        static int FindProductIndexByName(string productName)
        {
            foreach (var product in products)
            {
                if (product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return Array.IndexOf(products, product);
                }
            }

            return -1;
        }
        static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Adds the key without showing it in console
                if (key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                }
            }
            while (key.Key != ConsoleKey.Enter);

            return password;
        }
        static void GetChoiceClientMenu(string[] clientMenu)
        {
            for (int i = 0; i < clientMenu.Length; i++)
            {
                Console.WriteLine(clientMenu[i]);
            }
        }
        static int ReadUniqueClientId()
        {
            int clientId = ReadInteger(MIN_ID_VALUE_CLIENT+clientCount, MAX_ID_VALUE_CLIENT);

            while (ClientIdExists(clientId))
            {
                Console.WriteLine("**CLIENT ID ALREADY EXISTS. CREATE A DIFFERENT ID**");
                clientId = ReadInteger(MIN_ID_VALUE_CLIENT, MAX_ID_VALUE_CLIENT);
            }

            return clientId;
        }
        static bool ClientIdExists(int clientId)
        {
            foreach (var client in clients)
            {
                if (client.Id == clientId)
                {
                    return true;
                }
            }
            return false;
        }
        static void RecordSale(Client client, Product product, int quantity, double subTotalPrice, double taxes, double totalPrice)
        {
            if (purchaseCount == MAX_CLIENT_CAPACITY)
            {
                Console.WriteLine("**MAX PURCHASE RECORD CAPACITY REACHED**");
                return;
            }

            purchases[purchaseCount] = new Purchase(client, new Product[] { product }, subTotalPrice, taxes, totalPrice);
            purchaseCount++;
        }
        static void DisplayPurchasesByClient(Client client)
        {
            Console.WriteLine($"PURCHASES MADE BY {client.FirstName} {client.LastName} (ID: {client.Id}):\n");

            bool purchasesFound = false;

            foreach (var purchase in purchases)
            {
                if (purchase.Client.Id == client.Id)
                {
                    purchasesFound = true;
                    Console.WriteLine($"PURCHASE DATE: {DateTime.Now}");
                    Console.WriteLine($"SUBTOTAL: ${purchase.Subtotal}");
                    Console.WriteLine($"TAXES: ${purchase.Taxes}");
                    Console.WriteLine($"TOTAL PRICE: ${purchase.TotalPrice}\n");

                    Console.WriteLine("Products Purchased:");
                    foreach (var product in purchase.Products)
                    {
                        Console.WriteLine($"- {product.Name}, Quantity: {purchase.Subtotal / product.UnitPrice}, Unit Price: ${product.UnitPrice}");
                    }

                    Console.WriteLine("\n------------------------\n");
                }
            }

            if (!purchasesFound)
            {
                Console.WriteLine("**NO PURCHASES FOUND**");
            }

            Console.ReadLine();
        }
        static void TotalSales()
        {
            double totalSales = purchases.Sum(p => p.TotalPrice);

            Console.WriteLine($"TOTAL SALES: ${totalSales}");
        }
        static void AllSales()
        {
            if (purchaseCount == 0)
            {
                Console.WriteLine("**NO SALES REGISTERED**");
                return;
            }

            for (int i = 0; i < purchaseCount; i++)
            {
                Console.WriteLine($"SALE #{i + 1}: SUBTOTAL: ${purchases[i].Subtotal}, TAXES: ${purchases[i].Taxes}, TOTAL: ${purchases[i].TotalPrice}");
            }
        }

        #endregion

        #region MENU LAYOUT
        #region mainMenu
        static string[] mainMenu = { "1. SIGN IN.", "2. EXIT APPLICATION." };
        #endregion
        #region signInMenu
        static string[] signInMenu = { "1. SIGN IN AS EMPLOYEE.", "2. SIGN IN AS CLIENT", "3. EXIT" };
        #endregion
        #region employeeMenu
        static string[] employeeMenu = {"1. CREATE PRODUCT",
                                     "2. MODIFY PRODUCT",
                                     "3. DISPLAY PRODUCTS SORTED BY ID",
                                     "4. CREATE CLIENT",
                                     "5. MODIFY CLIENT",
                                     "6. DISPLAY CLIENTS SORTED BY ID",
                                     "7. SELL PRODUCTS",
                                     "8. DISPLAY SALES",
                                     "9. DISPLAY TOTAL OF SALES",
                                     "10. SIGN OUT"};
        #endregion
        #region clientMenu
        static string[] clientMenu = {"1. DISPLAY PRODUCTS",
                                   "2. MY PURCHASES",
                                   "3. SIGN OUT"};
        #endregion
        #endregion
        static void Main(string[] args)
        {
            while (true)
            {                
                ShowMainMenu();
            }
        }
    }
}



