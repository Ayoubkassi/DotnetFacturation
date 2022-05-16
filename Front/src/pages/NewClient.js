import TextField from '@material-ui/core/TextField';
import Button from '@mui/material/Button';
import { useState } from 'react';
import axios from 'axios';



const NewClient = () => {
  const [firstName , setFirstName] = useState(null);
  const [lastName , setLastName] = useState(null);
  const [respName , setRespName] = useState(null);
  const [rs , setRS] = useState(null);
  const [typeClient , setTypeClient] = useState(null);
  const [tel , setTel] = useState(null);
  const [portable , setPortable] = useState(null);
  const [fax , setFax] = useState(null);
  const [email , setEmail] = useState(null);
  const [adresse , setAdresse] = useState(null);
  const [ville , setVille] = useState(null);
  const [pays , setPays] = useState(null);
  const [iF , setIF] = useState(null);
  const [patente , setPatente] = useState(null);
  const [ice , setICE] = useState(null);


  const addClient =  () => {
    console.log("heere");
    axios.post('http://localhost:6000/api/v1/clients', {
      RS : rs,
      NomResp : respName,
      TypeClient : typeClient,
      Nom : lastName,
      Prenom : firstName ,
      Tel : tel,
      Portable:portable,
      Fax : fax,
      Email:email,
      Adresse:adresse,
      Ville: ville,
      Pays: pays,
      IF: iF,
      Patent : patente,
      ICE : ice,
      RC: "Default"
      })
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
  }

  return(
    <div className="container mt-4">
      <h1 className="text-center mb-4">Add New Client</h1>
      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="FirstName" variant="outlined" onChange={ (e) => setFirstName(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="LastName" variant="outlined" onChange={ (e) => setLastName(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="RespName" variant="outlined" onChange={ (e) => setRespName(e.target.value) }/>
        </div>
      </div>

      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="RS" variant="outlined" onChange={ (e) => setRS(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="TypeClient" variant="outlined" onChange={ (e) => setTypeClient(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Tel" variant="outlined" onChange={ (e) => setTel(e.target.value) }/>
        </div>
      </div>

      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Portable" variant="outlined" onChange={ (e) => setPortable(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Fax" variant="outlined" onChange={ (e) => setFax(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Email" variant="outlined" onChange={ (e) => setEmail(e.target.value) }/>
        </div>
      </div>


      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Adresse" variant="outlined" onChange={ (e) => setAdresse(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Ville" variant="outlined" onChange={ (e) => setVille(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Pays" variant="outlined" onChange={ (e) => setPays(e.target.value) } />
        </div>
      </div>

      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="IF" variant="outlined" onChange={ (e) => setIF(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Ptente" variant="outlined" onChange={ (e) => setPatente(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="ICE" variant="outlined" onChange={ (e) => setICE(e.target.value) }/>
        </div>
      </div>

      <div className="mt-4">
        <Button variant="contained" onClick={addClient}>Add Client</Button>
      </div>

    </div>
  );
}

export default NewClient;
