import logo from "./logo.svg";
import "./App.css";
import React from "react";
import Login from "./login";
// import Password
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
function App() {
  return (
    <div className="App">
      <Router>
        <Routes>
          <Route exact path="/" element={<Login />}></Route>
        </Routes>
      </Router>
    </div>
  );
}

export default App;
