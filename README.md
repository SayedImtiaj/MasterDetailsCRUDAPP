Sure! Here’s a `README.md` without the code snippets:

---

# MasterDetailsCRUDAPP

## Introduction

**MasterDetailsCRUDAPP** is a Windows Forms application developed in C# that manages trainees, courses, and enrollments using SQL Server. The application also includes reporting capabilities through Crystal Reports, providing a robust solution for managing and reporting on educational data.

## Features

- **Trainee Management**: Add, edit, delete, and view trainee records.
- **Course Management**: Manage courses, including details and fees.
- **Enrollment Tracking**: Track and manage trainee enrollments in courses.
- **Reporting**: Generate and view detailed reports on trainees using Crystal Reports.

## Database Structure

### Tables

1. **Trainee**
   - **TraineeID**: Unique identifier for each trainee.
   - **TraineeName**: Name of the trainee.
   - **CourseID**: Identifier for the course the trainee is enrolled in.
   - **DOB**: Date of birth.
   - **Gender**: Gender of the trainee.
   - **ImagePath**: Path to the trainee's profile image.

2. **Course**
   - **CourseID**: Unique identifier for each course.
   - **Course**: Name of the course.
   - **CourseFee**: Fee for the course.

3. **EnrollCourse**
   - **EnrollCourseID**: Unique identifier for each enrollment.
   - **TraineeID**: Identifier for the trainee.
   - **CourseID**: Identifier for the course.
   - **EnrollDate**: Date when the trainee enrolled.
   - **EnrollFee**: Fee paid by the trainee.

### Stored Procedures

- **TraineeEnrollAddOrEdit**: Manages the insertion and updating of enrollment records.
- **EnrollCourseDelete**: Deletes a specific enrollment record.
- **TraineeAddOrEdit**: Manages the insertion and updating of trainee records.
- **TraineeDelete**: Deletes a trainee and their associated enrollments.
- **TraineeViewAll**: Retrieves a list of all trainees.
- **TraineeViewByID**: Retrieves details of a specific trainee along with their enrollments.

## Setup Instructions

### Prerequisites

- **Visual Studio 2019** or later
- **SQL Server** (LocalDB is recommended for development)
- **Crystal Reports** for Visual Studio

### Installation Steps

1. **Clone the Repository**

   Clone the project repository to your local machine.

2. **Open in Visual Studio**

   Open the solution file (`MasterDetailsCRUDAPP.sln`) in Visual Studio.

3. **Database Configuration**

   Ensure the SQL Server database (`TraineeDB.mdf`) is attached. Adjust the connection string in `App.config` if needed to match your SQL Server setup.

4. **Build and Run**

   Build the solution in Visual Studio and run the application to start managing trainees, courses, and enrollments.

## Usage

- **Trainee Management**: Use the Trainee section to manage trainee records, including creating, updating, and deleting trainees.
- **Course Management**: View and manage courses and their associated fees in the Course section.
- **Enrollment Management**: Handle trainee enrollments in courses, including managing fees and enrollment dates.
- **Reporting**: Generate and view reports on trainees using the integrated Crystal Reports viewer.

## Contribution

Contributions are welcome! If you'd like to contribute to the project, please fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License. For more details, see the [LICENSE](LICENSE) file.

## Contact

For questions, suggestions, or issues, please contact the project maintainer at [your.email@example.com](mailto:your.email@example.com).

---

This version provides a clear, concise overview of your project without including specific code examples.
