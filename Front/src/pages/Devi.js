import TextField from '@material-ui/core/TextField';
import Button from '@mui/material/Button';
import axios from 'axios';
import {useState , useEffect} from 'react';


const baseURL = "/api/v1/devis";


const Devi = () => {

    const [devis, setDevis] = useState(null);

    const getDevis = async () => {
     const response = await axios.get(baseURL);
     console.log(response.data);
     setDevis(response.data);
    };

    useEffect(() => {
      getDevis();

  }, []);



    if (!devis) return (
        <div className="mt-4">
            <h1  className="text-center mb-2">Devis</h1>
        </div>
      );

  return (
    <>
    <h1 className="text-center mt-4">Devis</h1>
    <div className="container mt-4">
      <br/>
      <table className="table">
      <thead className="thead-dark">
        <tr>
        <th>ID</th>
        <th>Prix</th>
        <th>Quantite</th>
        <th>Date</th>
        </tr>
      </thead>
      <tbody>
      {
        devis.map(devi => (
          <tr>
            <td>{devi.id}</td>

          </tr>
        ))
      }
      </tbody>
      </table>

      <div>
        <button className="btn btn-primary">Add New Devi</button>
      </div>

    </div>
    </>
  );
}

export default Devi;
