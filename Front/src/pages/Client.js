import TextField from '@material-ui/core/TextField';
import Button from '@mui/material/Button';
import axios from 'axios';
import {useState , useEffect} from 'react';


const baseURL = "/api/v1/clients";


const Client = () => {

    const [clients, setClient] = useState(null);

    const getClients = async () => {
     const response = await axios.get(baseURL);
     console.log(response.data);
     setClient(response.data);
    };

    useEffect(() => {
      getClients();

  }, []);



    if (!clients) return (
        <div className="mt-4">
            <h1  className="text-center mb-2">Clients</h1>
        </div>
      );

  return (
    <>
    <h1 className="text-center mt-4">Clients</h1>
    <div className="container mt-4">
      <br/>
      <table className="table">
      <thead className="thead-dark">
        <tr>
        <th>ID</th>
        <th>FirstName</th>
        <th>LastName</th>
        <th>Pays</th>
        </tr>
      </thead>
      <tbody>
      {
        clients.map(client => (
          <tr>
            <td>{client.id}</td>
            <td>{client.prenom}</td>
            <td>{client.nom}</td>
            <td>{client.pays}</td>

          </tr>
        ))
      }
      </tbody>
      </table>

      <div>
        <button className="btn btn-primary"><a href="/new_client">Add New Client</a></button>
      </div>
    </div>
    </>
  );
}

export default Client;
