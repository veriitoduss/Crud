const express = require('express');

const router = express.Router();
const pool = require('../database.js');

//listar todos los usuario
router.get('/usuarios', async (req, res) => {
    const usuarios = await pool.query('SELECT * FROM usuario');
    res.json(usuarios);
  });

//agregar usuario
router.post('/agregar',async(req,res)=>{

    const informacion = {
        nombre_usuario: req.body.nombre_usuario,
        telefono: req.body.telefono,
        correo_electronico:req.body.correo_electronico
    }; 
    
    const sql = 'INSERT INTO usuario SET ?';
    await pool.query(sql,informacion);
    res.sendStatus(200);
  
  });
  //eliminar usuario
  router.get('/eliminar/:id', async(req,res)=>{
    const {id_usuario} = req.params;
    const usuario =await pool.query('DELETE FROM usuario WHERE id_usuario=?',[id_usuario]);
  });

module.exports = router;