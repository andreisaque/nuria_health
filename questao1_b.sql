select nome_paciente,data_atendimento,descricao_prontuario from pacientes p 
inner join atendimento atd on p.id_paciente = atd.id_paciente 
inner join pontuario pr on atd.id_atendimento = pr.id_atendimento
