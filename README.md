	Source code link: https://www.tutussfunny.com/react-with-asp-net-core-web-api-full-stack-crud-application/
	Video link: React with Asp.Net Core web Api Full Stack Crud Application
	
	React with Asp.Net Core web Api Full Stack Crud Application
	Ø Create database objects
	Ø Create Backend using .NET Core web API 
	Ø Create React js project
Backend
Nugget packages:
	• EntityFrameworkCore.Design 7.0.1
	• EntityFrameworkCore.SqlServer 7.0.1
	• EntityFrameworkCore.Tools 7.0.1
	• Newtonsoft.Json 13.0.2
	###Check these in dependencies > packages
	Sql server and sql ssms: https://www.sqlservertutorial.net/install-sql-server/
	Connect server  to ssms: https://www.sqlservertutorial.net/connect-to-the-sql-server/
	Server name: DESKTOP-49ELLTT\sa
	Password: 123
	
	PM> add-migration initial
	PM> update-database
	
	npx create-react-app aspcrud-frontend
	cd aspcrud-frontend
	npm  start
	
	Bootstrap: getbootstrap.com/docs/4.0/components/forms/
	Copy paste from first link: StudentCrud.js
	________________________________________________________________
	<h1>Student Details</h1>
	 <div class="container mt-4">
	 <form>
	 <div class="form-group">
	 
	<input
	 type="text"
	 class="form-control"
	 id="id"
	 hidden
	 value={id}
	 onChange={(event) => {
	 setId(event.target.value);
	 }}
	 />
	
	 <label>Student Name</label>
	 <input
	 type="text"
	 class="form-control"
	 id="stname"
	 value={stname}
	 onChange={(event) => {
	 setName(event.target.value);
	 }}
	 />
	 </div>
	 <div class="form-group">
	 <label>Course</label>
	 <input
	 type="text"
	 class="form-control"
	 id="course"
	 value={course}
	 onChange={(event) => {
	 setCourse(event.target.value);
	 }}
	 />
	 </div>
	 <div>
	 <button class="btn btn-primary mt-4" onClick={save}>
	 Register
	 </button>
	 <button class="btn btn-warning mt-4" onClick={update}>
	 Update
	 </button>
	 </div>
	 </form>
	 </div>
	 <br></br>
	
	 <table class="table table-dark" align="center">
	 <thead>
	 <tr>
	 <th scope="col">Student Id</th>
	 <th scope="col">Student Name</th>
	 <th scope="col">Course</th>
	 
	
	<th scope="col">Option</th>
	 </tr>
	 </thead>
	 {students.map(function fn(student) {
	 return (
	 <tbody>
	 <tr>
	 <th scope="row">{student.id} </th>
	 <td>{student.stname}</td>
	 <td>{student.course}</td>
	 
	<td>
	 <button
	 type="button"
	 class="btn btn-warning"
	 onClick={() => editStudent(student)}
	 >
	 Edit
	 </button>
	 <button
	 type="button"
	 class="btn btn-danger"
	 onClick={() => DeleteStudent(student.id)}
	 >
	 Delete
	 </button>
	 </td>
	 </tr>
	 </tbody>
	 );
	 })}
	 </table>
	
	From <https://www.tutussfunny.com/react-with-asp-net-core-web-api-full-stack-crud-application/?expand_article=1> 
	
	________________________________________________________________
	Above this add the function as well
	________________________________________________________________
	const [id, setId] = useState("");
	const [stname, setName] = useState("");
	const [course, setCourse] = useState("");
	const [students, setUsers] = useState([]);
	 
	useEffect(() => {
	 (async () => await Load())();
	 }, []);
	 
	async function Load() {
	 
	const result = await axios.get("https://localhost:7195/api/Student/GetStudent");
	 setUsers(result.data);
	 console.log(result.data);
	 }
	 
	async function save(event) {
	 
	event.preventDefault();
	 try {
	 await axios.post("https://localhost:7195/api/Student/AddStudent", {
	 
	stname: stname,
	 course: course,
	 
	});
	 alert("Student Registation Successfully");
	 setId("");
	 setName("");
	 setCourse("");
	 
	
	Load();
	 } catch (err) {
	 alert(err);
	 }
	 }
	
	 async function editStudent(students) {
	 setName(students.stname);
	 setCourse(students.course);
	 
	
	setId(students.id);
	 }
	 
	
	async function DeleteStudent(id) {
	 await axios.delete("https://localhost:7195/api/Student/DeleteStudent/" + id);
	 alert("Employee deleted Successfully");
	 setId("");
	 setName("");
	 setCourse("");
	 Load();
	 }
	 
	
	async function update(event) {
	 event.preventDefault();
	 try {
	
	 await axios.patch("https://localhost:7195/api/Student/UpdateStudent/"+ students.find((u) => u.id === id).id || id,
	 {
	 id: id,
	 stname: stname,
	 course: course,
	
	 }
	 );
	 alert("Registation Updateddddd");
	 setId("");
	 setName("");
	 setCourse("");
	 
	Load();
	 } catch (err) {
	 alert(err);
	 }
	 }
	
	From <https://www.tutussfunny.com/react-with-asp-net-core-web-api-full-stack-crud-application/?expand_article=1> 
	________________________________________________________________
	To access the Restful API: npm i axios
	To install bootstrap css: npm i bootstrap
	OR add the below to index.html file
	<linkrel="stylesheet"href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"crossorigin="anonymous">
	
	Now import these libraries as well in StudentCrud.js
	________________________________________________________________
	import axios from "axios";
	import { useEffect, useState } from "react";
	
	From <https://www.tutussfunny.com/react-with-asp-net-core-web-api-full-stack-crud-application/?expand_article=1> 
	
	________________________________________________________________
	
	Backend : https://localhost:7178/swagger/index.html
	Frontend: http://localhost:3000/
	
	FRONTEND- Deployment to git hub - https://github.com/gitname/react-gh-pages
	Video link: deploy react to gitpages
	###Using the steps after creating the repo worked.
	Did not work________________________________________________________________
	1. npm i gh-pages --save-dev
	2. Add in package.json as first line - 
	"homepage": "http://mrAkshatJoshi.github.io/aspcrud-frontend-react",
	3. Add a predeploy property and a deploy property to the scripts object:
	"predeploy": "npm run build",
	"deploy": "gh-pages -d build",
	4. git init 
	5. git remote add origin https://github.com/mrAkshatJoshi/aspcrud-frontend-react.git
	6. Readd if you made mistake in step 5
	git remote set-url origin  https://github.com/mrAkshatJoshi/aspcrud-frontend-react.git 
	7. npm run deploy
	8. Now go to the given url: 
	http://mrAkshatJoshi.github.io/aspcrud-frontend
	________________________________________________________________
	BACKEND- Deployment to git hub
	 
	



	
	
![image](https://github.com/mrAkshatJoshi/aspcoreWebAPI-frontend-react/assets/64397003/f6db2ad1-12dc-4505-8c37-8d8cb0e51249)
