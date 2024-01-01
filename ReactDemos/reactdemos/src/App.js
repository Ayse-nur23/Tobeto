// import Prop from "./oop/Prop";
// import MapFilterReduce from "./oop/MapFilterReduce";
// import RestSpreadDestructure from './oop/RestSpreadDestructure';
// import DataTypes from './oop/DataTypes';
import React from 'react'
import './App.css';
import Dashboard from './layouts/Dashboard';
import { Container } from 'semantic-ui-react';
import Navi from './layouts/Navi';

function App() {
  return (
    <div className="App">
      <Navi />
      <Container className="main">
        <Dashboard />
      </Container>

      {/* <DataTypes/>
        <Prop/>
        <RestSpreadDestructure/>
        <MapFilterReduce/> */}
    </div>
  );
}

export default App;