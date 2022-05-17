import TextField from '@material-ui/core/TextField';
import RadioButton from './components/RadioButton';
import Button from '@mui/material/Button';
import axios from 'axios';
import {useState , useEffect} from 'react';
import { BrowserRouter as  Router, Route , Routes } from "react-router-dom";
import './App.css';
import Home from './pages/Home';
import Client from './pages/Client';
import Devi from './pages/Devi';
import Facture from './pages/Facture';
import Navbar from './components/Navbar'
import NewClient from './pages/NewClient';
import NewFacture from './pages/NewFacture';
import NewDevi from './pages/NewDevi';

function App() {


  return (
    <>
    <Navbar/>
    <Router>
      <Routes>
        <Route path="/" exact element={<Home/>} />
        <Route path="/client"  element={<Client/>} />
        <Route path="/facture"  element={<Facture/>} />
        <Route path="/devi"  element={<Devi/>} />
        <Route path="/new_client"  element={<NewClient/>} />
        <Route path="/new_facture"  element={<NewFacture/>} />
        <Route path="/new_devi"  element={<NewDevi/>} />


      </Routes>
    </Router>
    </>
  );
}

export default App;
