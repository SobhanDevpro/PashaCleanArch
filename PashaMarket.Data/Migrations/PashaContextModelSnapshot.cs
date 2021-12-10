﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PashaMarket.Data.Context;

namespace PashaMarket.Data.Migrations
{
    [DbContext(typeof(PashaContext))]
    partial class PashaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PashaMarket.Domain.Entities.Account.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveCode")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Avatar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EmailActiveCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMobileActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuperUser")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MobileActiveCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailActiveCode = "abc9b8cd546844839b97b1ecfb386b76",
                            FirstName = "سبحان",
                            IsActive = true,
                            IsBlocked = false,
                            IsDelete = false,
                            IsEmailActive = true,
                            IsMobileActive = true,
                            IsSuperUser = false,
                            LastName = "عزتی",
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mobile = "09123456789",
                            MobileActiveCode = "765989",
                            Password = "123456"
                        });
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.ProductOrder.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recipient")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.ProductOrder.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PayablePrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(360)
                        .HasColumnType("nvarchar(360)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "D3200 از نظر سطح رقابتی چیزی هم رده‌ی دوربین Canon EOS 600D و البته رقیب آن قرار می‌گیرد. با این حال D3200 ویژگی‌هایی دارد که در بین دوربین‌های DSLR هم رده کاملا نوین محسوب می‌شود. نخستین آن‌ها سنسور تصویر 24 مگا پیکسلی است. تا به این تاریخ DSLR ی در این رده، با این رزولوشن بالا ساخته نشده بود. در ضمن این دوربین برای نخستین بار در بین دوربین‌های این کلاس، از یونیت قابل انتخاب Wi-Fi مدل WU-1a هم پشتیبانی می‌کند. این دوربین اکنون توانایی ضبط ویدیویی 1080p Full HD در 30 فریم بر ثانیه را دارد و نمایشگر 3 اینچی آن نیز رزولوشن 921,000 پیکسل را ارائه می‌دهد.",
                            ImageName = "15e24b7479ab46fda23371183e6fa82b.jpg",
                            Inventory = 25,
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 13400000,
                            ShortDescription = "این دوربین مناسب عکاسانی می‌باشد که یا تازه قصد دارند پا به عرصه‌ی عکاسی با دوربین‌های DSLR بگذارند و یا اینکه ابعاد بزرگ و قیمت بالای دوربین‌های رده‌ی Prosumer (مثل D7000) را نمی‌پسندند.",
                            Title = "دوربین دیجیتال نیکون مدل D3200 با لنز 18-55 F/3.5-5.6G ED II"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "از طراحی بدنهGem Cut نسل جدید Spectre های HP، لولاها، محل قرارگیری پورت‌ها، کیبورد و اسپیکرها گرفته تا رنگ‌بندی لوکس آن، همه‌چیز دست به دست هم داده‌اند تا با یک محصول کامل سروکار داشته باشیم. بدنه‌ی این آلترابوک با آلومینیوم ماشین‌کاری شده CNC در قسمت‌ رویی و فیبر کربن در قسمت‌های زیرین ساخته شده و تنها 1.3 کیلوگرم وزن و 16 میلی‌متر ضخامت دارد؛ ضخامتی به اندازه‌ی یک خودکار معمولی. لولاهای متصل‌کننده صفحه‌نمایش به بدنه هم طراحی عالی دارند و به کم‌شدن این ضخامت کمک شایانی کرده‌اند. صفحه‌نمایش ۱۳.۳ اینچی این آلترابوک پنل IPS با وضوح Full HD و روکش براق دارد و توسط لایه‌ی محافظ Corning Gorilla Glass هم پوشانده شده است، همچنین بابهره مندی از تکنولوژی HP Sure View فشردن یک کلید بر روی کیبورد، زاویه دید صفحه نمایش را بسیار محدود کرده و فقط برای کاربر قابل دیدن است و از اطراف هیچ دیدی نخواهد داشت. ",
                            ImageName = "4f7120a32fc7441fbd83456b01a15ca3.jpg",
                            Inventory = 12,
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 49700000,
                            ShortDescription = "Spectre x360 13t-AW200-B شرکت «اچ‌پی» یکی از زیباترین و جذاب‌ترین آلترابوک‌هایی محسوب می‌شود که تا کنون تولید شده است.",
                            Title = "لپ تاپ 13.3 اینچی اچ پی مدل Spectre 13T AW200-B"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "از ویژگی‌های این گوشی موبایل می‌توان به باتری لیتیوم یون با ظرفیت 5000 میلی‌آمپر اشاره کرد که این میزان شما را از شارژ مداوم گوشی موبایل بی‌نیاز می‌کند. این محصول قابلیت شارژ سریع با توان 25 وات را دارد و از فناوری شارژ سریع PD نسخه سوم پشتیبانی می‌کند. از دیگر قابلیت‌های گوشی Galaxy S21 Ultra 5G می‌توان به برخورداری از قابلیت شارژ بی‌سیم Qi/PMA با توان 15 وات اشاره کرد. دوربین 108 مگاپیکسلی این موبایل آن را برای انجام عکاسی حرفه‌ای هم به گزینه‌ای مناسب بدل کرده است. این گوشی قابلیت شارژ بی‌سیم دستگاه‌های دیگر (Power Bank/Reverse Wireless Charging) با توان 4.5 وات دارا است. گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS دو سیم کارت ظرفیت 512 گیگابایت و رم 16 گیگابایت می‌تواند شگفت‌ترین گوشی سامسونگ باشد. در سری Galaxy S21 شارژر و هندزفری حذف شده است.",
                            ImageName = "348e80b2dc954225952b14e120625904.jpg",
                            Inventory = 20,
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 33000000,
                            ShortDescription = " گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS دو سیم کارت ظرفیت 512 گیگابایت از به‌روزترین و باکیفیت‌ترین گوشی‌های موجود در بازار است طراحی زیبا و کارایی مناسبی دارد.",
                            Title = "گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "کیفیت‌تصویر این تلویزیون 4K است و تصاویر را با وضوح و شفافیت بسیار بالایی نمایش می‌دهد. زاویه‌ دید وسیعی دارد و امکان تماشای صفحه‌نمایش را از محدوده‌ وسیعی فراهم می‌کند. نسبت تصویر آن 16:9 است و تصویر را با ابعاد متناسبی به پخش می‌گذارد. سیستم‌صوتی تلویزیون DSL-50K5700U دوکاناله است و به‌واسطه سیستم‌های صوتی بسیار قدرتمند Surround و Dolby Digital Plus می‌تواند کیفیت صدای بسیار مطلوبی را تولید کند. شرکت سازنده برای این مدل، دو عدد درگاه USB در نظر گرفته شده است. با استفاده از این 2 پورت می‌توانید فلش‌مموری و هارد اکسترنال خود را به تلویزیون متصل کرده و از فایل‌های موجود در آن‌ها استفاده کنید. برای اتصال پخش‌کننده‌ها به این تلویزیون می‌توانید از بین درگاه HDMI و کامپوزیت و کامپوننت یکی را انتخاب کنید. درگاه HDMI قادر است تصاویر را با کیفیت 4K به صفحه‌نمایش منتقل کند. از دیگر ویژگی‌های جالب این مدل، می‌توان به قابلیت ماشین زمان (Time Shift) اشاره کرد؛ کارایی این قابلیت به این صورت است که با ذخیره‌کردن برنامه‌ درحال‌پخش، می‌توانید به لحظات قبلی بازگردید. فرمت‌های تصویری قابل‌پشتیبانی این مدل بسیار متنوع است و به شما کمک می‌کند که به‌راحتی، فایل‌های دلخواه خود را به‌وسیله‌ی درگاه ارتباطی موردنظر پخش ‌کنید. این تلویزیون به‌همراه یک عدد ریموت ‌کنترل ارائه می‌شود که کارایی بسیار ساده‌ای دارد. تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ توانایی پخش و پشتیبانی از شبکه‌های تلویزیونی 4K و HD صدا و سیما را دارا است.",
                            ImageName = "bbf9860cbccb4407a1806718e1a726aa.jpg",
                            Inventory = 8,
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 11500000,
                            ShortDescription = "تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ محصولی بادوام و خوش‌ساخت از این برند است که امکانات متعددی را در اختیار کاربرانش می‌گذارد",
                            Title = "تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "تلویزیون‌ها هم مانند دیگر تولیدات کارخانه‌ها با پیشرفت تکنولوژی دستخوش تغییرات زیادی شده‌اند و در مدل‌های متنوع با قابلیت‌های متفاوت تولید می‌شوند. در این میان برند دوو یکی از تولیدکنندگان این کالای پرمصرف است که محصولاتش با استقبال بالایی مواجه شده‌اند. تلویزیون ال ای دی دوو مدل DLE-50K4310U سایز 50 اینچ، از گیرنده‌ی دیجیتالی و تيونر DVBT2 بهره می‌برد. کیفیت تصویر آن 4k-Ultra HD است و قابلیت Mega Contrast دارد. این تلویزیون با سه درگاه HDMI و دو درگاه USB امکان اتصال ابزارهای دیجیتال نظیر فلش و هارد از طریق پورت USB و یا اتصال Play Station و لپ تاپ را از طریق پورت HDMI برای کاربر فراهم می‌کند.",
                            ImageName = "c0ce120897a74bbaa62969242d087f92.jpg",
                            Inventory = 12,
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 10500000,
                            ShortDescription = "برند دوو برند لوازم خانگی دوو برای اولین بار در سال 1963 در سئول کره‌ی جنوبی تأسیس شد. این برند یکی از مرغوب‌ترین و با کیفیت‌ترین برندهای لوازم خانگی است که در میان مصرف‌کنندگان طرفداران زیادی دارد.",
                            Title = "تلویزیون ال ای دی دوو مدل DLE-50K4310U سایز 50 اینچ"
                        });
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Products.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("UrlName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "کالای دیجیتال",
                            UrlName = "Electronic-Devices"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 1,
                            Title = "گوشی موبایل",
                            UrlName = "Mobile-Phone"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 1,
                            Title = "لپ تاپ",
                            UrlName = "NoteBook"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 1,
                            Title = "دوربین",
                            UrlName = "Camera"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "خانه و آشپزخانه",
                            UrlName = "Home-And-Kitchen"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 5,
                            Title = "صوتی و تصویری",
                            UrlName = "Video-Audio-Entertainment"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentId = 5,
                            Title = "لوازم برقی خانگی",
                            UrlName = "Home-Appliance"
                        });
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Products.ProductSelectedCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSelectedCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 4,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 2,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 5,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 6,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 5,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductCategoryId = 6,
                            ProductId = 5
                        });
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Site.SiteBanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BannerPlacement")
                        .HasColumnType("int");

                    b.Property<string>("ColSize")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("SiteBanners");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.ProductOrder.Order", b =>
                {
                    b.HasOne("PashaMarket.Domain.Entities.Account.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.ProductOrder.OrderDetail", b =>
                {
                    b.HasOne("PashaMarket.Domain.Entities.ProductOrder.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Products.ProductSelectedCategory", b =>
                {
                    b.HasOne("PashaMarket.Domain.Entities.Products.ProductCategory", "ProductCategory")
                        .WithMany("ProductSelectedCategories")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PashaMarket.Domain.Entities.Products.Product", "Product")
                        .WithMany("ProductSelectedCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.ProductOrder.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Products.Product", b =>
                {
                    b.Navigation("ProductSelectedCategories");
                });

            modelBuilder.Entity("PashaMarket.Domain.Entities.Products.ProductCategory", b =>
                {
                    b.Navigation("ProductSelectedCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
