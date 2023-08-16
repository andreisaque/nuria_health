select * from atendimento where data_atendimento 
between add_months(trunc(current_date), -6) and current_date AND CD_ESPECIALIDADE = 'Oncologia'
