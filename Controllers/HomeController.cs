using Microsoft.AspNetCore.Mvc;
using SandrasPortfolio.Models;

namespace SandrasPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["BodyClass"] = "home-bg";
            return View();
        } 

       /* [HttpGet]
        public IActionResult Contact()
        {
           return View();
        }*/

        
        public IActionResult Projects()
        {
            ViewData["BodyClass"] = "projects-bg";
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Smart Feedback System",
                    Description = @"It is a <b>full-stack web application</b> built to collect, process,
and view user feedback efficiently. It showcases a modern cloud-native architecture by combining server-based APIs,
serverless functions,        and cloud storage, making it scalable and maintainable for real-world us",
                    Technologies = @" <div>
                       <span><b> ⚙️ Backend – ASP.NET Core Web API</b> </span>

                       <li> Receives and serves feedback data to the frontend.</li>
                       <li> Exposes RESTful endpoints for feedback submission and retrieval.  </li>
                       <li> Handles CORS, routing, and filtering logic. </li>
                       <li> Integrated with Azure Table Storage via service layer.</li>
                    </div> 
                    <div>
                        <span><b>☁️ Serverless – Azure Function App</b></span>
                        <li> Processes feedback submissions in an event-driven manner.</li>
                        <li> Stores feedback data in Azure Table Storage.</li>
                        <li> Runs on demand, reducing resource usage and cost.</li>
                        <li> Suitable for future enhancements like email triggers or sentiment analysis.</li>
                        
                    </div>
                    <div>
                        <span><b> 💾 Storage – Azure Table Storage</b></span>
                        <li> NoSQL storage for storing structured feedback data.</li>
                        <li> Fast, scalable, and cost-effective for log or feedback storage.</li>
                     </div>

                     <div>
                        <span><b>🎨 Frontend – React + CSS</b></span>
                        <li> Built with React (Vite) for fast development and performance.</li>
                        <li>Two main pages:
                          <li>- Submit Feedback – form for users to send feedback.</li>
                          <li>- View Feedback – displays stored feedback with rating filters.</li>
                        </li> 
                      </div>",
                    GitHubLink = "https://github.com/e-l-z-a/SmartFeedbackSystem"
                },
                new Project
                {
                    Title = "Personal Finance Manager",
                    Description = @"It is a <b>ASP.NET MVC Project</b> that allows users to track income, expenses, and savings goals, helping them manage their personal finances more effectively.             ",
                    Technologies = @"<div>
                        <span><b> 🚀 Features</b> </span>
                        
                        <li> User Authentication Secure registration and login system. Each user's data is kept private using identity-based filtering.</li>
                        <li> Income Management Add, view, and delete income entries. Fields: Amount, Source, DateReceived, Notes.  </li>
                        <li> Expense Tracking Categorized expense tracking with date, description, and amount. Dynamically loaded categories using SelectList. </li>
                        <li> Savings Goals Set and monitor personal saving goals.</li>
                        <li> Dashboard Personalized dashboard showing the logged-in user’s name. Summary and quick links to income, expenses, and savings.</li>
                        <li> Responsive UI Clean Bootstrap 5-based interface with layout customization.</li>
                    </div> 
                    <div>
                               
                        <span><b>🛠️ Technologies Used</b></span>

                        <li>Backend - ASP.NET Core MVC (Model-View-Controller).</li>
                        <li>Frontend - Styling Bootstrap 5 CDN</li>
                        <li>Database -  Entity Framework Core + SQL Server</li>
                        <li>Authentication - ASP.NET Core Identity</li>
                        <li>Data Models - C# POCO Models with Annotations</li>
                        <li>View Engine - Razor Views (.cshtml) </li>
                        <li>Validation - Data Annotations + Client-side Scripts</li>
                        <li>Security - Anti-forgery tokens, Role-based access</li>
                        <li>Dev Tools - Visual Studio, NuGet, Git</li>
                       
                        
                    </div>",
                    GitHubLink = "https://github.com/e-l-z-a/FinanceManager",
                    LiveDemoLink = ""
                },
                 new Project
                {
                    Title = "AchillesChat",
                    Description = @"AchillesChat combines structured knowledge with AI-powered semantic matching to deliver a friendly, character-driven chat experience. It’s a practical example of how <b>ML.NET</b> can enhance chatbots, while maintaining full control over persona-specific responses.",
                    Technologies = @"<div>
                        <span><b>🚀 Features</b> </span>
                        
                        <li>Persona-specific Q&A with speaker attribution (Achilles, Patroclus, or Both.</li>
                        <li>Semantic similarity search using ML.NET (FeaturizeText + cosine similarity).</li>
                        <li>Fallback small talk and unsure responses when no confident match is found.</li>
                        <li>Integration with OpenAI GPT for out-of-scope questions.</li>
                        <li>Minimal frontend chat interface with live messaging.</li>
                    </div> 
                    <div>
                               
                        <span><b>🛠️ Technologies Used</b></span>

                        <li>⚙️ Backend - ASP.NET Core</li>
                        <li>📊 AI/ML - ML.NET (text featurization + cosine similarity)</li>
                        <li>🎨 Frontend - HTML, JavaScript</li>
                        <li>💾 Data Storage - JSON file for knowledge base</li>
                        <li>🤖 AI Integration : OpenAI GPT API</li>
                       
                        
                    </div>",
                    GitHubLink = "https://github.com/e-l-z-a/AchillesChat",
                    LiveDemoLink = ""
                },
                new Project
                {
                    Title = "Library Management SQL System",
                    Description = @"This project simulates a Library Book Borrowing and Recommendation System, designed using <b>SQL Server</b> to showcase advanced relational database design and querying skills.",
                    Technologies = @"<div>
                        <span><b> Features</b> </span>
                        
                        <li> 🧱 Normalized schema for managing users, books, borrowing, and ratings.</li>
                        <li> ⚙️ Stored procedures for reusable and dynamic operations. </li>
                        <li> 🔁 Triggers for logging return events. </li>
                        <li> 👁️ Views for simplified data access and analysis. </li>
                        <li> 📊 Advanced queries using CTEs, window functions, joins, and aggregations.</li>
                        <li> 📌 Entity-Relationship Diagram (ERD) for clear database architecture.</li>
                    </div> 
                    <div>
                               
                        <span><b>🛠️ Technologies Used</b></span>

                        <li>SQL Server Management Studio (SSMS)	- Writing, testing, and managing SQL scripts.</li>
                        <li>Microsoft SQL Server - Relational database engine</li>
                        <li>T-SQL (Transact-SQL) - SQL dialect used for procedures, queries, and triggers</li>
                        <li>GitHub - Code hosting and portfolio showcase</li>
                       
                        
                    </div>",
                    GitHubLink = "https://github.com/e-l-z-a/LibraryManagementSql",
                    LiveDemoLink = ""
                }
            };

            return View(projects);
        }

     
        public IActionResult Contact()
        {
            ViewData["BodyClass"] = "contact-bg";
            return View();
        }

        public IActionResult About()
        {
            ViewData["BodyClass"] = "about-bg";
            var skills = new List<skill>
            {
                new skill
                {
                    Name=" 💻 Languages",
                    Description=@" 
                    <li>C#</li>
                <li>ASP.Net</li>
                <li>HTML</li>
                <li>CSS</li>
                <li>React</li>"
                   
                },
                new skill
                {
                    Name = " 🛢️ Databases",
                    Description=@"<li>MSSQL</li>
                <li>MySQL</li>
                <li>DB2</li>
                <li>Postgresql</li>"
                },
                new skill
                {
                    Name =" ☁️ Azure Services",
                    Description=@"<li>FunctionAppL</li>
                <li>LogicApp</li>
                <li>Storage Accounts</li>
                <li>Service Bus</li>
                <li>Cosmos DB</li>"
                },
                new skill
                {
                    Name =" 📊 ETL & Reporting",
                    Description=@"<li>SSIS</li>
                <li>SSRS</li>
                <li>Informatica</li>"
                },
                new skill
                {
                    Name =" 🛠️ Tools and Platform",
                    Description=@"<li>VisualStudio (2019/2022)</li>
                <li>Sql Server Management Studio</li>
                <li>DBeaver</li>
                <li>ServiceNow</li>
                <li>Visual Studio Code</li>"
                },
                new skill
                {
                    Name =" 🔄 Version Control",
                    Description=@"<li>GIT</li>
                <li>Azure DevOps</li>"
                },
                new skill
                {
                    Name =" 📋 Methodologies",
                    Description=@"<li>Scrum</li>
                <li>Agile</li>"
                }
            };
            return View(skills);
        }
    }
}