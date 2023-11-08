window.MostraAlerta = (Message) => {
    alert(message);
}

function getTotalTarefa() {
    DotNet.invokeMethodAsync("TarefasBlazor", "ObterTotal").Then(r => {
        alert("Total de tarefas: " + r);
    });
}

function getTotalTarefaInstance(dotnet) {
    dotnet.invokeMethodAsync("TarefasBlazor", "ObterTotalInstancia").Then(r => {
        alert("Total de tarefas: " + r);
    });
}