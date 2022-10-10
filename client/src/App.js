
import React from "react";
import { Routes, Route } from "react-router-dom";
import Login from "./components/login";
import Private from "./components/private";
import "bootstrap/dist/css/bootstrap.min.css";

function App() {
  return (
    <div>
      <div className="container-md mt-5">
        <Routes>
          <Route path="/private" element={<Private />} />
          <Route path="/" element={<Login />} />
        </Routes>
      </div>
    </div>
  );
}

export default App;