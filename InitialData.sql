insert ignore into Forms.Forms(`Key`, Name, Title, Description)
values ('ContactUs', N'Contact Us', N'Contact Us', 'Contact us about anything. We would gladly hear it from you.');

select Id into @formId
from Forms.Forms
where `Key` = 'ContactUs';

select Id into @textFieldId
from Forms.FieldTypes
where `Key` = 'Text';

select Id into @singleChoiceFieldId
from Forms.FieldTypes
where `Key` = 'SingleChoice';

select Id into @numericFieldId
from Forms.FieldTypes
where `Key` = 'Numeric';

select Id into @longTextFieldId
from Forms.FieldTypes 
where `Key` = 'LongText';

select Id into @dateFieldId
from Forms.FieldTypes 
where `Key` = 'Date';

select Id into @multiChoiceFieldId
from Forms.FieldTypes 
where `Key` = 'MultiChoice';

select Id into @fileFieldId
from Forms.FieldTypes 
where `Key` = 'File';

select Id into @multipleFilesFieldId
from Forms.FieldTypes 
where `Key` = 'MultipleFiles';

select Id into @booleanFieldId
from Forms.FieldTypes 
where `Key` = 'Boolean';

insert ignore into Forms.Fields(FormId, `Key`, FieldTypeId, Label, Placeholder, Hint, Icon, IsRequired, Regex, DefaultValue, Direction, `Order`) values
(@formId, 'Name', @textFieldId, 'Name', 'Your name', 'Please provide your full 
name.', null, 1, null, null, null, 0),
(@formId, 'Email', @textFieldId, 'Email', 'Your email', null, null, 1, null, null, null, 1),
(@formId, 'Phone', @textFieldId, 'Phone', 'Your phone', 'Personal numbers are more convenient.', null, 0, null, null, null, 2),
(@formId, 'Message', @longTextFieldId, 'Message', 'Write your message here...', 'Please be as specific about your request as possible.', null, 1, null, null, null, 3)