 *{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

nav{
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 20px;
}

ul{
    display: flex;
    list-style: none;
    text-decoration: none;
    gap: 20px;
}

ul li a{
    text-decoration: none;
    color: #5c656d;
}

ul li a:hover{
    text-decoration: underline red;

}
main{
    display: flex;
    justify-content: space-between;
}

nav ul  button{
    background: black;
    color: white;
    padding: 10px;
}


.center{
    display: flex;
    align-items: center;
    justify-content: center;
    margin-left: 100px;
}



button:hover{
    background: transparent;
    color: black;
}


img:hover{
    transform: scale(0.8);
}