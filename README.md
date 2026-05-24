### Step 1: Update the File

```markdown
# ASP.NET Core MVC Assessment

## Prerequisites
To run this project locally, you will need:
* [.NET SDK](https://dotnet.microsoft.com/download) (Built using .NET 10.0)
* No external database server is required. This project uses **Entity Framework Core with SQLite** for easy testing.

## How to Run the Project

1. **Clone the repository:**
```bash
   git clone [https://github.com/Rahman-22/DotNetAsessment.git](https://github.com/Rahman-22/DotNetAsessment.git)
   cd DotNetAsessment

```

2. **Restore dependencies:**

```bash
   dotnet restore

```

3. **Run the application:**

```bash
   dotnet run

```

4. **Open in Browser:**
Look at the terminal output for the local port (e.g., `http://localhost:5195`) and open it in your web browser.

## Testing the Requirements

Once the application is running, navigate to the following routes to view the completed assessment tasks:

### Part 1: Employee Biodata Filtering

**URL:** `http://localhost:<PORT>/Employee`

* **Requirement:** Display a list of employees whose names start with "A", "G", or "V", and whose birth dates fall within the 1st quarter (Jan-Mar) of the year.
* **Database Auto-Seeding:** Upon the first launch, Entity Framework Core will automatically create a local `local_assessment.db` SQLite file, generate the `employee_biodata` table, and seed it with the exact 5 records provided in the assessment instructions.

### Part 2: Dynamic Control Generator

**URL:** `http://localhost:<PORT>/DynamicControl`

* **Requirement:** A web page that dynamically generates standard HTML controls (Textbox, Checkbox, Button) based on user input for the desired control type and the desired quantity.
