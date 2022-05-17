import TextField from '@material-ui/core/TextField';
import Button from '@mui/material/Button';
import axios from 'axios';
import {useState , useEffect} from 'react';


const baseURL = "/api/v1/factures";


const Facture = () => {

    const [factures, setFactures] = useState(null);

    const getFactures = async () => {
     const response = await axios.get(baseURL);
     console.log(response.data);
     setFactures(response.data);
    };

    useEffect(() => {
      getFactures();

  }, []);



    if (!factures) return (
        <div className="mt-4">
            <h1  className="text-center mb-2">Factures</h1>
        </div>
      );

  return (
    <>
    <h1 className="text-center mt-4">Factures</h1>
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
        factures.map(facture => (
          <tr>
            <td>{facture.id}</td>
            <td>{facture.prix}</td>
            <td>{facture.quantite}</td>
            <td>{facture.date}</td>
          </tr>
        ))
      }
      </tbody>
      </table>

      <div>
        <button className="btn btn-primary"><a href="/new_facture">Add New Facture</a></button>
      </div>

    </div>
    </>
  );
}

export default Facture;
