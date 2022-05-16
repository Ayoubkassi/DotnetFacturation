import {useState , useEffect} from 'react';
import Navbar from '../components/Navbar';
import Jumbo from '../components/Jumbo';
import '../App.css';

const Home = () => {
  return (
      <div className="App">
        <div className="container mt-4">
          <Jumbo/>
        </div>
      </div>
  );
}

export default Home;
