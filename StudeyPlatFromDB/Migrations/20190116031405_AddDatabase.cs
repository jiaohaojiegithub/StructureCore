using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudeyPlatFromDB.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "S_Address",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    province = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    areaid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    area = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    street = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    postcode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    contact = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    isdefault = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    update = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Address", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Answer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    testpaperid = table.Column<int>(nullable: true),
                    sumscore = table.Column<int>(nullable: true),
                    testtime = table.Column<int>(nullable: true),
                    istest = table.Column<int>(nullable: true),
                    ischeck = table.Column<int>(nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    enddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Answer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Answersub",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    answerid = table.Column<int>(nullable: true),
                    subjectid = table.Column<int>(nullable: true),
                    answer = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    isright = table.Column<int>(nullable: true),
                    score = table.Column<int>(nullable: false),
                    ischeck = table.Column<int>(nullable: false),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Answersub", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    categoryname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    parentid = table.Column<int>(nullable: true),
                    type = table.Column<int>(nullable: true),
                    cruid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    permit = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Comment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    courseid = table.Column<int>(nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    content = table.Column<string>(maxLength: 4000, nullable: true),
                    integral = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Comment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_CommentReply",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    courseid = table.Column<int>(nullable: true),
                    commentid = table.Column<int>(nullable: true),
                    author = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    content = table.Column<string>(maxLength: 4000, nullable: true),
                    integral = table.Column<int>(nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_CommentReply", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Course",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    permit = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "((1))"),
                    categoryid = table.Column<int>(nullable: true),
                    title = table.Column<string>(maxLength: 50, nullable: true),
                    bgimg = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    videoimg = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    detail = table.Column<string>(nullable: true),
                    duration = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fileurl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    readnum = table.Column<int>(nullable: true),
                    cruid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    enddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    update = table.Column<DateTime>(type: "datetime", nullable: true),
                    upuid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Course", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Depot",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    province = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    depotName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Depot", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_EntryForm",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    depotname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    username = table.Column<string>(maxLength: 50, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    courseid = table.Column<int>(nullable: true),
                    timeid = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_EntryForm", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_EntryTime",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    courseid = table.Column<int>(nullable: false),
                    time = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_EntryTime", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_FeedBack",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    content = table.Column<string>(maxLength: 1000, nullable: true),
                    isreply = table.Column<int>(nullable: false),
                    reply = table.Column<string>(maxLength: 1000, nullable: true),
                    replyname = table.Column<string>(maxLength: 50, nullable: true),
                    replydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_FeedBack", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Goods",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    goodsimg = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    goodsname = table.Column<string>(maxLength: 200, nullable: true),
                    integral = table.Column<int>(nullable: true),
                    stock = table.Column<int>(nullable: true),
                    online = table.Column<int>(nullable: true),
                    exchangeTime = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    remark = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Goods", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Grade",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    reg = table.Column<int>(nullable: true),
                    greenhand = table.Column<int>(nullable: true),
                    salesskill = table.Column<int>(nullable: true),
                    professionalknowledge = table.Column<int>(nullable: true),
                    allcourse = table.Column<int>(nullable: true),
                    comment = table.Column<int>(nullable: true),
                    reply = table.Column<int>(nullable: true),
                    feedback = table.Column<int>(nullable: true),
                    grade = table.Column<int>(nullable: true),
                    gradename = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Grade", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_GradeType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    grade = table.Column<int>(nullable: true),
                    gradename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    staus = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_GradeType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Integral",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<int>(nullable: true),
                    action = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    content = table.Column<string>(maxLength: 100, nullable: true),
                    relateid = table.Column<int>(nullable: true),
                    integral = table.Column<int>(nullable: true),
                    remark = table.Column<string>(maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Integral", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_IntegralRole",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    rolename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    integral = table.Column<int>(nullable: true),
                    remark = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_IntegralRole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Manager",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    userid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    username = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    headimgurl = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Manager", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Menu",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    menuname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    imgurl = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    sort = table.Column<int>(nullable: true),
                    cruid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Menu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_MobileCode",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    code = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_MobileCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Notice",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    type = table.Column<int>(nullable: true),
                    courseid = table.Column<int>(nullable: true),
                    relateid = table.Column<int>(nullable: true),
                    action = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    content = table.Column<string>(maxLength: 1000, nullable: true),
                    unread = table.Column<int>(nullable: true),
                    replyuid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    readdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Notice", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    contact = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    goodsid = table.Column<int>(nullable: true),
                    goodsname = table.Column<string>(maxLength: 200, nullable: true),
                    integral = table.Column<int>(nullable: true),
                    addressid = table.Column<int>(nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    step = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_ReadInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    courseid = table.Column<int>(nullable: true),
                    readtime = table.Column<int>(nullable: true),
                    times = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    lastdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_ReadInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Role",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    rolename = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    cruid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_RoleMenu",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    roleid = table.Column<int>(nullable: true),
                    menuid = table.Column<int>(nullable: true),
                    type = table.Column<int>(nullable: true),
                    cruid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_RoleMenu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Subject",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    testpaperid = table.Column<int>(nullable: true),
                    title = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    option = table.Column<string>(maxLength: 500, nullable: true),
                    right = table.Column<string>(maxLength: 500, nullable: true),
                    category = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    sort = table.Column<int>(nullable: true),
                    score = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_TestPaper",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    bgimg = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    remark = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    papertime = table.Column<int>(nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    enddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    isend = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    isaward = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    categoryid = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_TestPaper", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_Token",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    token = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    update = table.Column<DateTime>(type: "datetime", nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Token", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_UserAction",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    url = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    pagename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    telversion = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    elapsedtime = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserAction", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_UserInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    openid = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    username = table.Column<string>(maxLength: 50, nullable: true),
                    nickname = table.Column<string>(maxLength: 50, nullable: true),
                    headimgurl = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    sex = table.Column<int>(nullable: true),
                    province = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    country = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    depotid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    depotname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    position = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    real_integral = table.Column<int>(nullable: true),
                    all_integral = table.Column<int>(nullable: true),
                    grade = table.Column<int>(nullable: true),
                    unionid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    usertype = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    isreg = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    regdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    commentnum = table.Column<int>(nullable: true),
                    replynum = table.Column<int>(nullable: true),
                    feedbacknum = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    upuid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_UserRole",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    roleid = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    type = table.Column<int>(nullable: true),
                    cruid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserRole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_UserType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    typename = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_VideoInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    uid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    courseid = table.Column<int>(nullable: true),
                    videoname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    sumwatchtime = table.Column<int>(nullable: true),
                    times = table.Column<int>(nullable: true),
                    iswatchsure = table.Column<int>(nullable: true),
                    crdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    lastdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_VideoInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "S_WXbase",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    appid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    appsecret = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    update = table.Column<DateTime>(type: "datetime", nullable: true),
                    tab = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_WXbase", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__s_Manage__DD701265117F9D94",
                table: "S_Manager",
                column: "uid",
                unique: true,
                filter: "[uid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__s_Manage__CBA1B2560EA330E9",
                table: "S_Manager",
                column: "userid",
                unique: true,
                filter: "[userid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__s_Role__4685A0621FCDBCEB",
                table: "S_Role",
                column: "rolename",
                unique: true,
                filter: "[rolename] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Address");

            migrationBuilder.DropTable(
                name: "S_Answer");

            migrationBuilder.DropTable(
                name: "S_Answersub");

            migrationBuilder.DropTable(
                name: "S_Category");

            migrationBuilder.DropTable(
                name: "S_Comment");

            migrationBuilder.DropTable(
                name: "S_CommentReply");

            migrationBuilder.DropTable(
                name: "S_Course");

            migrationBuilder.DropTable(
                name: "S_Depot");

            migrationBuilder.DropTable(
                name: "S_EntryForm");

            migrationBuilder.DropTable(
                name: "S_EntryTime");

            migrationBuilder.DropTable(
                name: "S_FeedBack");

            migrationBuilder.DropTable(
                name: "S_Goods");

            migrationBuilder.DropTable(
                name: "S_Grade");

            migrationBuilder.DropTable(
                name: "S_GradeType");

            migrationBuilder.DropTable(
                name: "S_Integral");

            migrationBuilder.DropTable(
                name: "S_IntegralRole");

            migrationBuilder.DropTable(
                name: "S_Manager");

            migrationBuilder.DropTable(
                name: "S_Menu");

            migrationBuilder.DropTable(
                name: "S_MobileCode");

            migrationBuilder.DropTable(
                name: "S_Notice");

            migrationBuilder.DropTable(
                name: "S_Order");

            migrationBuilder.DropTable(
                name: "S_ReadInfo");

            migrationBuilder.DropTable(
                name: "S_Role");

            migrationBuilder.DropTable(
                name: "S_RoleMenu");

            migrationBuilder.DropTable(
                name: "S_Subject");

            migrationBuilder.DropTable(
                name: "S_TestPaper");

            migrationBuilder.DropTable(
                name: "S_Token");

            migrationBuilder.DropTable(
                name: "S_UserAction");

            migrationBuilder.DropTable(
                name: "S_UserInfo");

            migrationBuilder.DropTable(
                name: "S_UserRole");

            migrationBuilder.DropTable(
                name: "S_UserType");

            migrationBuilder.DropTable(
                name: "S_VideoInfo");

            migrationBuilder.DropTable(
                name: "S_WXbase");
        }
    }
}
