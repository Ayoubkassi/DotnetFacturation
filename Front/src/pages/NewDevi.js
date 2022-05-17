import TextField from '@material-ui/core/TextField';
import Button from '@mui/material/Button';
import { useState } from 'react';
import axios from 'axios';



const NewDevi = () => {
  const [rs , setRS] = useState(null);
  const [total , setTotal] = useState(null);
  const [status , setStatus] = useState(null);
  const [quantite , setQuantite] = useState(null);
  const [date , setDate] = useState(null);
  const [deviseNumber , setDeviseNumber] = useState(null);
  const [clientId , setClientId] = useState(null);
 


  const addDevi =  () => {
    console.log("heere");
    axios.post('http://localhost:6000/api/v1/devis', {
      RS : rs,
      Status : status,
      Quantite : quantite,
      Date : date,
      Total:total,
      ClientId:clientId,
      DevisNumber : deviseNumber
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
      <h1 className="text-center mb-4">Add New Devis</h1>
      
      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="RS" variant="outlined" onChange={ (e) => setRS(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Status" variant="outlined" onChange={ (e) => setStatus(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="DevisNumber" variant="outlined" onChange={ (e) => setDeviseNumber(e.target.value) }/>
        </div>
      </div>

      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Quantite" variant="outlined" onChange={ (e) => setQuantite(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Total" variant="outlined" onChange={ (e) => setTotal(e.target.value) }/>
        </div>
        <div className="col-md-4">
          <TextField id="outlined-basic" label="Date" variant="outlined" onChange={ (e) => setDate(e.target.value) }/>
        </div>
      </div>


      <div className="row mt-4">
        <div className="col-md-4">
          <TextField id="outlined-basic" label="ClientID" variant="outlined" onChange={ (e) => setClientId(e.target.value) } />
        </div>
      </div>

      

      <div className="mt-4">
        <Button variant="contained" onClick={addDevi}>Add Devis</Button>
      </div>

    </div>
  );
}

export default NewDevi;
