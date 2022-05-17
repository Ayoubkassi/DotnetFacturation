import TextField from '@material-ui/core/TextField';
import Button from '@mui/material/Button';
import { useState } from 'react';
import axios from 'axios';



const NewFacture = () => {
  const [designation , setDesignation] = useState(null);
  const [rs , setRS] = useState(null);
  const [status , setStatus] = useState(null);
  const [quantite , setQuantite] = useState(null);
  const [prix , setPrix] = useState(null);
  const [date , setDate] = useState(null);
  const [total , setTotal] = useState(null);
  const [reference , setReference] = useState(null);
  const [clientId , setClientId] = useState(null);
 


  const addFacture =  () => {
    console.log("heere");
    axios.post('http://localhost:6000/api/v1/factures', {
      RS : rs,
      Status : status,
      Designation : designation,
      Quantite : quantite,
      Prix : prix ,
      Date : date,
      Total:total,
      Reference : reference,
      ClientId:clientId
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
      <h1 className="text-center mb-4">Add New Facture</h1>
      
      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="RS" variant="outlined" onChange={ (e) => setRS(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Status" variant="outlined" onChange={ (e) => setStatus(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Designation" variant="outlined" onChange={ (e) => setDesignation(e.target.value) }/>
        </div>
      </div>

      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Quantite" variant="outlined" onChange={ (e) => setQuantite(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Prix" variant="outlined" onChange={ (e) => setPrix(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Date" variant="outlined" onChange={ (e) => setDate(e.target.value) }/>
        </div>
      </div>


      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Total" variant="outlined" onChange={ (e) => setTotal(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Reference" variant="outlined" onChange={ (e) => setReference(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="ClientID" variant="outlined" onChange={ (e) => setClientId(e.target.value) } />
        </div>
      </div>

      

      <div className="mt-4">
        <Button variant="contained" onClick={addFacture}>Add Facture</Button>
      </div>

    </div>
  );
}

export default NewFacture;
