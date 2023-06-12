using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NokoodAssignment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppTB_Trip",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTB_Trip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppTB_Reservation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTB_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTB_Reservation_AppTB_Trip_TripId",
                        column: x => x.TripId,
                        principalTable: "AppTB_Trip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppTB_Reservation_TripId",
                table: "AppTB_Reservation",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppTB_Reservation");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AppTB_Trip");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
