import ReactHTMLTableToExcel from 'react-html-table-to-excel';
import {useState,useEffect} from 'react';
import axios from 'axios';



const Export = () => {

	const baseURL = "/api/v1/clients";
	const [clients, setClient] = useState(null);

    const getClients = async () => {
     const response = await axios.get(baseURL);
     console.log(response.data);
     setClient(response.data);
    };

    useEffect(() => {
      getClients();

  }, []);


	return(
	
			<div className="container">
                <h3 className="mt-3 text-success"><center>Export React Table Data into EXCEL Sheet</center></h3>
                <div className="row mt-4">
                <ReactHTMLTableToExcel
                    id="test-table-xls-button"
                    className="download-table-xls-button btn btn-success mb-3"
                    table="table-to-xls"
                    filename="tablexls"
                    sheet="tablexls"
                    buttonText="Export Data to Excel Sheet"/>
                   <table className="table" id="table-to-xls">
                    <thead className="thead-dark">
                    <tr>
                        <th>ID</th>
                        <th>Firstname</th>
                        <th>Lastname</th>
                        <th>Pays</th>
                    </tr>
                    </thead>
                    <tbody>
                   
                         {clients.map((client)=>
                            <tr>
                            <td>{client.id}</td>
                            <td>{client.prenom}</td>
                            <td>{client.nom}</td>
                            <td>{client.pays}</td>
                            </tr>
                          )}   
                       
                    </tbody>   
                </table>
             </div>
            </div>

	);
}

export default Export;