var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
console.log(connection);

connection.on("ReceiveMessage",function(user,message){
    var li = document.createElement("li");
    document.querySelector(".box-chat").appendChild(li);
    li.textContent = `${user} : ${message}`;
})

connection.start();

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("messageUser").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        console.log(err);
    })
    event.preventDefault();
})