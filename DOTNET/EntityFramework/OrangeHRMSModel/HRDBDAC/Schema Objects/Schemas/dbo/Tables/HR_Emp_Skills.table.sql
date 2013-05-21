CREATE TABLE [dbo].[HR_Emp_Skills](
	[EmployeeNumber] [bigint] NOT NULL,
	[SkillID] [int] NOT NULL,
	[ExperienceInMonths] [int] NULL,
	[ExperienceInYears] [int] NULL,
	[TotalExperience] [int] NULL,
	[HR_LKP_Skill_SkillID] [int] NOT NULL,
 CONSTRAINT [PK_HR_Emp_Skills] PRIMARY KEY CLUSTERED 
(
	[EmployeeNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_Emp_SkillsHR_LKP_Skill] FOREIGN KEY([HR_LKP_Skill_SkillID])
REFERENCES [dbo].[HR_LKP_Skill] ([SkillID])
)


