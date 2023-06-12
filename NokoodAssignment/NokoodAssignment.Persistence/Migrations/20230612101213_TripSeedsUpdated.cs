using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NokoodAssignment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TripSeedsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("17a7b6ca-1e11-277d-e898-be5706bff707"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("199d9dee-5811-afdd-1f20-3e77d10807a0"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("2193acf1-74a4-c4d2-546d-76135d554fa3"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("4ca07784-db0e-1ecf-fdeb-c9e549deada1"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("51f62381-5060-b3a0-4865-e13e77d5cd13"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("536672ae-e64d-030b-41a9-4da7c626a2e4"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("6bb2cc0d-51fa-f492-0eb6-55177a27af6e"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8c9d37c2-7022-f934-ca4a-723501e8aa06"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8e15a41d-fef3-2ef7-23b6-8fa565d0b17c"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("a0b20f39-8a22-069f-7530-e2e6ad3f5681"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("b4e0ddd4-044a-9b18-05f9-f2a77a42f779"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("bb017765-6a33-65bc-2026-667fcd3f91a1"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9a7744c-2878-531f-77cb-b893e558ffd3"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("dd9de15a-f3fa-eaa3-3f33-16887f457188"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("de7a1bf1-86b4-a5e4-42c6-c75bafa66c0b"));

            migrationBuilder.InsertData(
                table: "AppTB_Trip",
                columns: new[] { "Id", "CityName", "Content", "CreationDate", "CreatorId", "ImageUrl", "Name", "Notes", "Price" },
                values: new object[,]
                {
                    { new Guid("203bc3f2-ad3d-b249-327f-51349be2c0c6"), "Lavonnebury", "navigating multi-byte brand Tasty Plastic Fish Lead Vermont task-force Bulgaria payment Awesome Wooden Chips port THX Vista Cross-group European Unit of Account 9(E.U.A.-9) RSS French Guiana Cambridgeshire interface Light Guyana West Virginia synergies synthesize cross-media Applications Money Market Account payment Tasty Wooden Mouse payment Barbados Program directional Avon morph Supervisor Grocery & Home Comoros Intelligent Granite Bacon instruction set Alley partnerships Rustic Frozen Fish Dobra Accountability empowering generating TCP Credit Card Account Buckinghamshire connecting COM Zambia Lead RAM TCP Taka bus Cambridgeshire bluetooth", new DateTime(2023, 6, 11, 21, 1, 0, 848, DateTimeKind.Local).AddTicks(3983), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/sports", "sensor", null, 495.88999999999999 },
                    { new Guid("364b6ab4-c385-f5cc-0e68-033416a2bb16"), "Eldonport", "Heard Island and McDonald Islands Licensed THX North Dakota Central Spurs Factors Engineer capacitor Lead indigo deliverables New Hampshire networks pixel Technician upward-trending 4th generation auxiliary Steel Cloned Alaska Games, Baby & Automotive silver Licensed Metal Salad installation optical Networked Buckinghamshire stable Wall systematic maroon Investment Account payment implement Lock streamline Gorgeous bypass Timor-Leste Ways firewall auxiliary RSS Assistant maroon impactful invoice Handcrafted Soft Chips circuit Estates Inlet Concrete Rubber Handcrafted Frozen Chair out-of-the-box Technician leverage Credit Card Account", new DateTime(2023, 6, 12, 5, 52, 29, 757, DateTimeKind.Local).AddTicks(3727), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/cats", "ability", null, 257.12 },
                    { new Guid("3a440876-3fe7-beac-9438-59b1f45e3dd0"), "South Melyssa", "Paradigm EXE Shoes, Books & Kids Tasty Cotton Sausages Supervisor PNG synthesize Finland withdrawal e-services methodology knowledge user SSL Ramp payment Savings Account Awesome Rubber Cheese GB Small Soft Chair Garden & Music Glens Cliffs generate Ergonomic hacking National Progressive Graphic Interface functionalities Generic mindshare Investor withdrawal Enterprise-wide Quality-focused Games, Home & Outdoors Security override Practical Soft Shoes array Circles Principal partnerships Incredible Fresh Tuna technologies deposit bandwidth Handmade Rubber Salad Route sky blue wireless Bedfordshire haptic Quality Fresh leading-edge Rubber Operations indexing revolutionize", new DateTime(2023, 6, 11, 22, 55, 38, 477, DateTimeKind.Local).AddTicks(310), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/nightlife", "system", null, 151.09 },
                    { new Guid("86fef317-218e-962a-8598-157d4a0fd57b"), "Lake Trinitymouth", "Bypass mission-critical Saint Helena solutions Outdoors, Games & Jewelery Cambridgeshire XSS even-keeled Refined Home Loan Account Principal Belarussian Ruble Crescent Small grey extensible Analyst Avon Practical Wooden Bike solid state Sleek Soft Shirt Web Oregon Borders Granite cyan deposit Cross-platform Unbranded Rubber Shoes enhance platforms compress object-oriented ROI infrastructures USB Outdoors & Tools JSON Checking Account Implementation calculating Product Senior coherent Convertible Marks Gorgeous Plastic Tuna Checking Account Georgia Ville Buckinghamshire Tasty Soft Chicken Handmade Cotton Mouse Mount feed Cambridgeshire Sleek Granite Fish Quality Future Incredible Concrete Mouse Village", new DateTime(2023, 6, 12, 5, 8, 47, 307, DateTimeKind.Local).AddTicks(9842), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/city", "Direct", null, 566.61000000000001 },
                    { new Guid("8ab0371a-87dc-6bb7-2e67-cfcee7f27517"), "North Aaliyahfort", "Savings Account Games, Movies & Baby copying Rhode Island Automotive, Garden & Kids Handmade Metal Tuna Electronics & Garden maroon Louisiana synthesizing Jersey AI Illinois Vista grey Tasty Corporate Balanced violet XSS Fantastic Plastic Chicken executive Operations Administrator blue HTTP Home & Beauty Investment Account client-server Creative Rest programming systemic open-source Avon New Mexico Central Fork Sports, Shoes & Games South Dakota Concrete Fantastic Unions North Carolina e-business Future-proofed SDD visionary multimedia Future-proofed driver Checking Account Buckinghamshire redefine Credit Card Account contextually-based FTP Tasty Concrete Shoes Baht Chief", new DateTime(2023, 6, 11, 18, 39, 52, 197, DateTimeKind.Local).AddTicks(8706), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/people", "Checking Account", null, 475.62 },
                    { new Guid("9efd84c2-6045-636b-1205-f6f5296d6b5e"), "Littleside", "parsing Optimized Soft HDD aggregate Handmade Concrete Pizza Bedfordshire vortals deposit optimize Plastic Burundi SMS Functionality Gorgeous Fresh Computer Credit Card Account CSS Corporate synergy Cambridgeshire Future-proofed Borders e-tailers overriding experiences Radial AI withdrawal Austria auxiliary dot-com Sleek Plastic Chicken e-tailers Distributed Bouvet Island (Bouvetoya) Frozen reboot optical Checking Account tan mobile Object-based Iowa bus Junctions Forges bottom-line homogeneous transmitter Expressway withdrawal value-added Sleek Gorgeous Wooden Sausages Quality-focused tertiary Credit Card Account payment Skyway monetize", new DateTime(2023, 6, 12, 0, 54, 34, 202, DateTimeKind.Local).AddTicks(708), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/city", "XML", null, 318.29000000000002 },
                    { new Guid("acd458e2-b4e3-5764-6503-e2388c937b66"), "New Roxaneborough", "visualize Indiana Configurable object-oriented Small Concrete Towels Frozen bifurcated Unbranded Soft Shoes monetize Streamlined Tennessee programming Licensed Steel Bike Health Music & Garden Refined Rubber Keyboard Implemented Senior invoice Bahraini Dinar sexy Front-line Investment Account Analyst Intelligent Wooden parse Home & Toys Village e-markets Home Loan Account Gorgeous synthesize full-range Knoll Assimilated Intranet teal Home initiatives Saint Martin copying Nevada Intelligent needs-based Louisiana Bhutanese Ngultrum quantifying convergence empower generating Vietnam reboot relationships USB full-range e-markets moderator moratorium Kids, Toys & Tools", new DateTime(2023, 6, 12, 0, 46, 39, 113, DateTimeKind.Local).AddTicks(2302), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/animals", "Cotton", null, 1.96 },
                    { new Guid("add7394d-429c-bb40-ed9e-c4e61d61bf52"), "Russelstad", "Berkshire SDD repurpose portal Rubber function Rustic Officer synthesizing Configuration Ergonomic Metal Pants copying Beauty PCI Music & Movies Fantastic Concrete Computer Director virtual Vatu Stravenue Trail Internal initiatives maximized monitor Developer Wooden parallelism Toys & Clothing payment Designer indigo Handmade Rubber Table Handcrafted Fresh Ball mobile Jamaica Designer deliverables Fantastic parsing Track parsing USB pink Generic Steel Sausages e-business Chief dynamic Garden Lead Guyana Dollar parsing Forward Incredible Home Loan Account database benchmark Andorra Integration Garden, Electronics & Health", new DateTime(2023, 6, 12, 5, 54, 22, 260, DateTimeKind.Local).AddTicks(2026), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/abstract", "Yemeni Rial", null, 595.22000000000003 },
                    { new Guid("afb76db1-086b-1cf2-3524-62e6456cbff3"), "Stantonburgh", "Unbranded expedite Grocery mindshare synthesizing invoice orange North Dakota Metal quantifying online applications Frozen View Credit Card Account revolutionary Checking Account heuristic Generic Steel Soap gold SSL Integrated Technician Lari Horizontal Assistant Industrial & Garden Ergonomic Cambridgeshire Marketing Tools, Grocery & Music Strategist Books Licensed Plastic Bacon Turnpike Associate Ferry Money Market Account Regional Money Market Account payment violet Regional Dam Greenland Small Granite Computer Awesome indexing Incredible Legacy Configurable Louisiana Jewelery Expanded Passage digital bleeding-edge Keys red Rustic", new DateTime(2023, 6, 12, 8, 53, 10, 989, DateTimeKind.Local).AddTicks(2520), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/cats", "Baby, Games & Clothing", null, 317.48000000000002 },
                    { new Guid("b3426762-f995-81d2-95fb-4c16d136c3dd"), "Lake Henryside", "Lithuanian Litas HDD override Fantastic Wooden Towels Associate Granite Security Saint Kitts and Nevis Computers Central connecting pixel Tasty Plastic Salad microchip transmit index program Connecticut killer Quality red mobile teal Idaho Grenada Forward Buckinghamshire Industrial, Movies & Industrial tan Plastic optimize Handmade Granite Ball seize deposit Borders Berkshire local area network virtual Mount digital Ergonomic Wooden Hat overriding cross-media back up Kids & Automotive Plastic Generic Cotton Mouse gold Credit Card Account compressing Wyoming parsing Configuration Cross-group Wallis and Futuna Bouvet Island (Bouvetoya) Tasty Shoes Communications Optional", new DateTime(2023, 6, 12, 2, 32, 13, 734, DateTimeKind.Local).AddTicks(3881), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/technics", "Micronesia", null, 47.0 },
                    { new Guid("bccf1932-d54d-6f80-1548-b2fc7724ff9c"), "Angelicahaven", "invoice Iowa Borders Awesome Tennessee quantify Borders platforms Future Indiana overriding Incredible purple initiatives Frozen Crossing Investment Account Computers & Computers override forecast payment customer loyalty Boliviano boliviano Groves deploy bifurcated Awesome connecting Granite iterate Credit Card Account multi-byte Supervisor grey Pound Sterling Personal Loan Account back-end Profit-focused Generic Granite Sausages extend white value-added Maryland Sleek Rubber Shirt heuristic radical black Creative Manager Michigan SQL HDD Cotton Networked withdrawal port salmon Games drive installation", new DateTime(2023, 6, 12, 13, 10, 55, 836, DateTimeKind.Local).AddTicks(7672), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/food", "withdrawal", null, 592.97000000000003 },
                    { new Guid("dc7b03b1-d464-a408-891d-4c26e9b6a69c"), "North Judd", "projection RAM deliverables Finland Azerbaijan Drives function Home Loan Account deposit next-generation override View groupware Checking Account connect Expanded Usability backing up compressing Summit multi-byte Hill Gorgeous Optimization generating functionalities Functionality Aruban Guilder Taka parsing FTP Toys, Shoes & Jewelery Summit Money Market Account cross-platform SMTP solutions exploit payment purple Papua New Guinea Proactive Sleek Steel Computer payment Moldovan Leu Unbranded Rubber Shoes Configuration Automotive, Grocery & Books Cote d'Ivoire invoice index Rubber Berkshire Investment Account wireless generate monitor methodical strategize Angola", new DateTime(2023, 6, 11, 14, 19, 30, 694, DateTimeKind.Local).AddTicks(4143), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/business", "Cotton", null, 814.64999999999998 },
                    { new Guid("e56c0fd6-d348-8cc7-9086-62000926a424"), "Faustoview", "Buckinghamshire Branch Central pricing structure Plastic Maryland Savings Account Savings Account Chilean Peso Bypass Sleek Fresh functionalities Decentralized Kuwait Sharable one-to-one multi-byte program Liaison Generic Steel Pizza Buckinghamshire Fantastic Handcrafted Soft Bacon Practical back-end networks invoice bandwidth Tasty firewall Refined Frozen Shoes View Well Cambridgeshire Serbian Dinar Monitored Metal USB Money Market Account Bond Markets Units European Composite Unit (EURCO) Practical Plastic Computer quantifying invoice Forint Neck quantify Representative California Metal Berkshire deposit Florida Director Security distributed green models Home Bedfordshire", new DateTime(2023, 6, 12, 0, 37, 38, 434, DateTimeKind.Local).AddTicks(2030), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/transport", "Falkland Islands Pound", null, 167.94999999999999 },
                    { new Guid("ea0bc95a-54fa-e550-9a2b-6a21d0fe80f6"), "Lake Doris", "strategic Israel Roads CFA Franc BCEAO overriding Rubber Drive compress iterate Technician matrices Creek monitor backing up West Virginia Avon superstructure value-added Incredible Implementation Refined Rubber Table Passage XSS SCSI deposit Stand-alone Cordoba Oro Micronesia EXE lime bus global Marketing disintermediate SMTP indexing Illinois Reunion invoice multi-byte Branch transmit payment Barbados Handmade Synchronised SMTP Steel Equatorial Guinea Practical Engineer Health Direct Malaysian Ringgit Awesome Steel Chips copy override withdrawal Mississippi Monitored", new DateTime(2023, 6, 12, 12, 41, 19, 89, DateTimeKind.Local).AddTicks(6308), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/nature", "Investment Account", null, 126.97 },
                    { new Guid("ffc02a89-3075-01b7-cf7e-707c5802f9f0"), "New Aliyahbury", "Montana bluetooth eyeballs withdrawal innovative SDR Specialist Turks and Caicos Islands Wall Licensed efficient Generic Cotton Shoes solutions Arkansas Refined Steel Shoes Home Loan Account Swedish Krona withdrawal black Frozen Way withdrawal enable Station Well Berkshire intangible interface Executive Buckinghamshire Arkansas Sleek Soft Soap Unbranded Buckinghamshire circuit Somali Shilling one-to-one solid state global Money Market Account back-end orange Down-sized Alaska Avon Expressway Legacy Stravenue compress Granite Squares Tunnel Gorgeous Concrete Table Avon open-source robust olive Green invoice deposit", new DateTime(2023, 6, 12, 2, 35, 30, 862, DateTimeKind.Local).AddTicks(9859), new Guid("78a7570f-3ce5-48ba-9461-80283ed1d94d"), "http://lorempixel.com/640/480/business", "Czech Koruna", null, 373.74000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("203bc3f2-ad3d-b249-327f-51349be2c0c6"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("364b6ab4-c385-f5cc-0e68-033416a2bb16"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("3a440876-3fe7-beac-9438-59b1f45e3dd0"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("86fef317-218e-962a-8598-157d4a0fd57b"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8ab0371a-87dc-6bb7-2e67-cfcee7f27517"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("9efd84c2-6045-636b-1205-f6f5296d6b5e"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("acd458e2-b4e3-5764-6503-e2388c937b66"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("add7394d-429c-bb40-ed9e-c4e61d61bf52"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("afb76db1-086b-1cf2-3524-62e6456cbff3"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("b3426762-f995-81d2-95fb-4c16d136c3dd"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("bccf1932-d54d-6f80-1548-b2fc7724ff9c"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("dc7b03b1-d464-a408-891d-4c26e9b6a69c"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("e56c0fd6-d348-8cc7-9086-62000926a424"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("ea0bc95a-54fa-e550-9a2b-6a21d0fe80f6"));

            migrationBuilder.DeleteData(
                table: "AppTB_Trip",
                keyColumn: "Id",
                keyValue: new Guid("ffc02a89-3075-01b7-cf7e-707c5802f9f0"));

            migrationBuilder.InsertData(
                table: "AppTB_Trip",
                columns: new[] { "Id", "CityName", "Content", "CreationDate", "CreatorId", "ImageUrl", "Name", "Notes", "Price" },
                values: new object[,]
                {
                    { new Guid("17a7b6ca-1e11-277d-e898-be5706bff707"), "East Jarrod", "next-generation invoice Orchestrator Kroon Colorado systematic SCSI Money Market Account Administrator back up Forward Cambridgeshire Borders Branding Fresh Plastic analyzer Incredible Metal Pants withdrawal productize Jamaica copying hard drive green value-added firewall online Rubber Falkland Islands Pound firmware multi-byte Practical Granite Hat transmit engineer toolset contextually-based program Gold Poland Forge service-desk Awesome Plastic Chair e-business Buckinghamshire Bedfordshire circuit actuating array Denar Future Metal Investment Account Spurs Avon indexing Handcrafted Cotton Bike Reactive reboot green transmit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/sports", "Cyprus", null, 514.57000000000005 },
                    { new Guid("199d9dee-5811-afdd-1f20-3e77d10807a0"), "South Geofort", "systemic Liberian Dollar optical repurpose Money Market Account Games impactful Games magnetic Dale Bedfordshire Soft Tasty Metal Soap Handmade Frozen Ball index Shoes & Computers collaboration payment Engineer synthesize Moroccan Dirham Kansas Granite Rwanda Franc Customer database Lead Shoes invoice Auto Loan Account override Handmade Brand Missouri Consultant world-class Cloned USB Specialist firewall Avon Fiji Dollar bypassing cutting-edge Human integrate driver Cedi Rubber teal Sports & Music indexing Baby & Music Fork Ways Inverse New York Loop synthesizing Plaza", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/city", "Borders", null, 277.86000000000001 },
                    { new Guid("2193acf1-74a4-c4d2-546d-76135d554fa3"), "Kihnland", "invoice Bedfordshire Gorgeous Concrete Ball Connecticut pink responsive Synchronised Versatile Communications Strategist Implementation mobile zero administration local area network Cross-group local invoice Colorado UAE Dirham Incredible Plastic Gloves synergize models collaborative Hryvnia firewall instruction set Steel Directives syndicate Books & Grocery Technician application Granite Kids pixel web-readiness implementation leverage bluetooth enhance Games Moldovan Leu Investor array Mandatory open-source initiative Enhanced firmware Interactions primary Circles Yen Savings Account National Optimization Gateway Divide black infrastructure", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/people", "Human", null, 160.31 },
                    { new Guid("4ca07784-db0e-1ecf-fdeb-c9e549deada1"), "Greenfort", "generate Coordinator Gorgeous Cotton Ball Pass Home, Home & Automotive parse Arizona transmitting Borders multi-byte Western Sahara payment Sudan budgetary management Savings Account RAM transform Graphical User Interface solution-oriented Gorgeous Granite Fish Mexican Peso capacitor Concrete partnerships Refined Turkey violet Accounts synthesizing deposit mesh Tunisian Dinar Berkshire Switchable matrix Rustic Granite Chair open-source Savings Account bottom-line Gourde monitor Small California Usability Savings Account Solomon Islands Dollar Incredible Cotton Shirt Computers & Shoes Lek Chief background Connecticut communities applications Re-engineered transform orchid Mission Response Analyst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/sports", "mobile", null, 796.70000000000005 },
                    { new Guid("51f62381-5060-b3a0-4865-e13e77d5cd13"), "Jazmyneberg", "Ports Extended orchestrate Greenland calculate override Kansas Springs lavender payment Concrete Handmade Wooden Computer Sleek Plastic Table Sleek leading-edge target primary withdrawal New Hampshire action-items Buckinghamshire non-volatile Officer Extensions web-readiness Eritrea viral Moldovan Leu Washington protocol Mauritius Rupee Officer markets Cambridgeshire North Korean Won Creative Handmade Concrete Shoes Implementation back-end Brunei Dollar Bond Markets Units European Composite Unit (EURCO) Cotton West Virginia mobile Australian Dollar Future Music & Garden frame redundant Throughway Plain California olive cyan Circle Nakfa array Home Loan Account convergence needs-based", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/business", "bi-directional", null, 482.52999999999997 },
                    { new Guid("536672ae-e64d-030b-41a9-4da7c626a2e4"), "Stromantown", "payment Interactions paradigms Kina Planner Borders Fresh Refined Fresh Towels Alabama program Integrated indexing Generic models Dynamic Investor coherent Canada next-generation payment Health & Jewelery deposit system engine CSS index Engineer drive Gardens cyan motivating installation PCI Buckinghamshire deposit Gorgeous Granite Mouse withdrawal Functionality Handmade Concrete Hat harness Integrated Accountability Music, Music & Jewelery Technician Turnpike GB Course Reactive Credit Card Account capacitor Operations Licensed Frozen Car back up killer Home Loan Account Sleek Coves payment Buckinghamshire deposit Jewelery, Electronics & Books", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/transport", "Future-proofed", null, 882.27999999999997 },
                    { new Guid("6bb2cc0d-51fa-f492-0eb6-55177a27af6e"), "West Tobyhaven", "Fantastic Cotton Ball content withdrawal violet RAM orchid Jewelery, Games & Beauty Idaho Books & Baby Consultant Rustic Cotton Chips Groves Avon grey national FTP Licensed Cotton Computer quantify Vermont protocol leading edge transmit overriding monitor Credit Card Account parse Greece drive Rubber Path Overpass auxiliary Developer infrastructures Orchestrator Generic Fresh Chair granular integrated Turnpike Technician generate optical innovative Human black Steel engage primary Refined Wooden Pizza program Spring Personal Loan Account parse Ville extensible Small Cotton Pizza transmitter Dynamic e-commerce Electronics, Games & Grocery", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/nightlife", "Concrete", null, 925.95000000000005 },
                    { new Guid("8c9d37c2-7022-f934-ca4a-723501e8aa06"), "Tyrafurt", "networks North Dakota benchmark envisioneer Hong Kong Frozen South Carolina Dynamic reintermediate morph Seychelles Rupee Small Cotton Chair Unbranded Practical Cotton Ball plum Generic Rubber Keyboard invoice Cape Verde unleash global Borders Monitored bottom-line Park Money Market Account payment violet focus group Nepalese Rupee pixel back up Money Market Account maximized mint green architectures Toys, Toys & Computers Fork Intelligent Beauty & Beauty Strategist override Generic Metal Ball visionary Malagasy Ariary object-oriented Small Granite Hat payment online Assimilated Practical Cotton Bike input strategize Courts Health Road deposit Center Principal Maryland Games, Automotive & Music", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/city", "Rustic Concrete Computer", null, 145.81999999999999 },
                    { new Guid("8e15a41d-fef3-2ef7-23b6-8fa565d0b17c"), "New Marquesbury", "multi-byte Metrics communities sexy Granite Wooden transmitter transitional Ouguiya Fantastic Frozen Shirt Course Plains Rustic Fresh Table salmon Coordinator Plastic 1080p Bedfordshire reboot Health Berkshire Buckinghamshire Handmade Fresh Ball port Lead array Intelligent Wooden Chips Estate North Carolina brand Texas program Borders Licensed Wooden Bike Awesome Concrete Pants JBOD Silver SAS connecting JBOD Team-oriented Computers Groves Games PNG Assistant implementation Maine firmware open-source deposit EXE Division Pass 24/7 Samoa Well reboot Wooden Path", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/business", "embrace", null, 777.66999999999996 },
                    { new Guid("a0b20f39-8a22-069f-7530-e2e6ad3f5681"), "Demetrisfort", "Cliffs granular architectures Turks and Caicos Islands Licensed Granite Car New Mexico interface Investor Money Market Account firewall Mountains Branding SCSI hack Investor Investment Account Implementation seamless Borders Handmade sky blue withdrawal Ethiopia Bedfordshire Cotton RAM Home Loan Account program grey Tajikistan time-frame Outdoors & Toys collaborative optical Books, Shoes & Electronics Small iterate Squares seize Auto Loan Account generate Sao Tome and Principe generate Cotton Sports & Kids Licensed Fresh Bike copy Borders logistical Licensed Metal Sausages Ridge Re-engineered CSS Cotton facilitate Clothing & Music bandwidth Cambridgeshire sensor Latvian Lats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/nightlife", "Borders", null, 224.46000000000001 },
                    { new Guid("b4e0ddd4-044a-9b18-05f9-f2a77a42f779"), "Sipeshaven", "cross-platform Saint Barthelemy Shores Auto Loan Account parsing Central sticky Infrastructure Borders open-source Developer Soft Health & Music service-desk Facilitator Optimization Unbranded Steel Chicken Senior Product interface Aruban Guilder Architect Garden throughput Djibouti Dynamic Metal Electronics Checking Account copy drive mobile Future Fresh panel Designer Liechtenstein Ergonomic Guarani Borders circuit Fresh Product green Intelligent Wooden Table Specialist AI Arizona Administrator Estates AI Books withdrawal eco-centric fault-tolerant User-friendly Egypt Fully-configurable connecting synthesize", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/abstract", "User-friendly", null, 150.41999999999999 },
                    { new Guid("bb017765-6a33-65bc-2026-667fcd3f91a1"), "Pfannerstillfort", "Markets primary e-business FTP Ergonomic Plastic Towels Avon Product deploy end-to-end Legacy Specialist Bulgarian Lev real-time asymmetric Investor best-of-breed Cayman Islands Sudanese Pound Key Direct Investor Integration Handcrafted Granite Chicken online 1080p SMTP Tasty Metal Ball Streets compelling Common Dynamic Kwanza Lilangeni Awesome Fresh Bacon Minnesota Botswana USB ADP high-level Bridge program generate Practical Fresh Bike Cotton Togo Cambridgeshire quantifying Designer Borders Unions Field back up iterate Libyan Dinar Coordinator Forward ROI holistic Group payment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/technics", "firewall", null, 237.00999999999999 },
                    { new Guid("d9a7744c-2878-531f-77cb-b893e558ffd3"), "Brionnahaven", "Avon Clothing quantifying Surinam Dollar Malawi revolutionize reboot solution-oriented synthesizing didactic static mobile pixel asynchronous indigo open-source array empowering salmon contingency strategy invoice Handcrafted Granite Bike Optimization Leone Gorgeous Metal Bike Markets District Ouguiya Walk transmit evolve ROI virtual Global Representative backing up Frozen Decentralized Saint Helena Pound Wooden deposit digital cultivate homogeneous Group Sports, Books & Grocery virtual Graphic Interface 24/365 monitor 24/365 Bangladesh THX Track channels turquoise Awesome Frozen Gloves withdrawal reintermediate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/business", "Cuban Peso Convertible", null, 968.92999999999995 },
                    { new Guid("dd9de15a-f3fa-eaa3-3f33-16887f457188"), "Manteshire", "Small Cotton Pants Movies, Shoes & Health User-centric Gold Refined Dong Kina Agent Directives Rustic Soft Hat collaborative Gorgeous navigate Way Ranch Central Buckinghamshire Tasty Granite Soap Cambridgeshire 6th generation Music & Sports Cambridgeshire overriding superstructure RSS channels Island input Unbranded Rubber Keyboard transparent Customer-focused Point Rand Directives programming e-markets Ways grey Functionality convergence Pakistan Rupee web-enabled Road Bahamian Dollar violet Row Licensed Wooden United Arab Emirates infrastructure invoice orange grow Handmade Soft Fish Prairie redundant Liaison Practical Concrete Towels Sleek Soft Keyboard Handmade", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/business", "Enterprise-wide", null, 88.620000000000005 },
                    { new Guid("de7a1bf1-86b4-a5e4-42c6-c75bafa66c0b"), "Kaleburgh", "Rubber Analyst Handmade neural capacitor matrix visualize Aruba Antarctica (the territory South of 60 deg S) Advanced CSS connect reinvent mint green Bedfordshire Configuration enhance mint green Cambridgeshire collaborative Legacy Expressway Avon e-business microchip efficient teal Delaware Forges interface Networked Creative Cambridgeshire needs-based seize program transmitting Generic Cotton Computer California Re-contextualized Awesome Baby & Kids District mission-critical intangible Intelligent 1080p regional HDD Causeway Assurance Soft Saint Vincent and the Grenadines Gardens Reduced payment Cayman Islands bandwidth application Crossroad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "http://lorempixel.com/640/480/animals", "Garden, Home & Shoes", null, 580.94000000000005 }
                });
        }
    }
}
