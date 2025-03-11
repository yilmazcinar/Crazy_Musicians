# Crazy_Musicians
This is # Crazy Musicians API

a simple ASP.NET Core Web API for managing a list of musicians with fun features.

## Endpoints

### Get All Musicians
- **URL:** `GET /api/musiciancontrollers`
- **Description:** Retrieves a list of all musicians.
- **Response:** 200 OK with a list of musicians.

### Get Musician by ID
- **URL:** `GET /api/musiciancontrollers/{id}`
- **Description:** Retrieves a musician by their ID.
- **Response:** 200 OK with the musician data, or 404 Not Found if the musician does not exist.

### Add a New Musician
- **URL:** `POST /api/musiciancontrollers`
- **Description:** Adds a new musician to the list.
- **Request Body:** JSON object with `FullName`, `Skill`, and `FunFeature`.
- **Response:** 201 Created with the created musician data.

### Update Musician
- **URL:** `PUT /api/musiciancontrollers/{id}`
- **Description:** Updates an existing musician's details.
- **Request Body:** JSON object with `FullName`, `Skill`, and `FunFeature`.
- **Response:** 200 OK with the updated musician data, or 404 Not Found if the musician does not exist.

### Update Musician's Skill
- **URL:** `PATCH /api/musiciancontrollers/{id}`
- **Description:** Updates an existing musician's skill.
- **Request Body:** JSON object with `Skill`.
- **Response:** 200 OK with the updated musician data, or 404 Not Found if the musician does not exist.

### Delete Musician
- **URL:** `DELETE /api/musiciancontrollers/{id}`
- **Description:** Deletes a musician by their ID.
- **Response:** 200 OK with a confirmation message, or 404 Not Found if the musician does not exist.

### Search Musicians by Name
- **URL:** `GET /api/musiciancontrollers/search`
- **Description:** Searches for musicians by their name.
- **Query Parameter:** `name` - The name to search for.
- **Response:** 200 OK with a list of matching musicians, or 404 Not Found if no musicians match the search criteria.

## Models

### Musician
- **Id:** int
- **FullName:** string (required, 5-50 characters)
- **Skill:** string (optional, 5-100 characters)
- **FunFeature:** string (optional, 5-100 characters)

### MusicianUpdate
- **FullName:** string (required, 5-50 characters)
- **Skill:** string (optional, 5-100 characters)
- **FunFeature:** string (optional, 5-100 characters)

### MusicianPatch
- **Skill:** string (optional, 5-100 characters)

## Requirements
- .NET 8
- ASP.NET Core 7.0

## Running the Application
1. Clone the repository.
2. Navigate to the project directory.
3. Run `dotnet restore` to install dependencies.
4. Run `dotnet run` to start the application.

## License
This project is licensed under the MIT License.
