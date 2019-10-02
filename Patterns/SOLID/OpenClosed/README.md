The open-closed principle states that classes should be open for an extension which means it should be possible to extend the product filter. But they should be closed for modification. Which means nobody should be going back into the filter and actually editing the code which is already there.

Rus: При́нцип откры́тости/закры́тости — принцип ООП, устанавливающий следующее положение: «программные сущности (классы, модули, функции и т. п.) должны быть открыты для расширения, но закрыты для изменения»
Принцип открытости/закрытости означает, что программные сущности должны быть:
открыты для расширения: означает, что поведение сущности может быть расширено путём создания новых типов сущностей.
закрыты для изменения: в результате расширения поведения сущности, не должны вноситься изменения в код, который эта сущность использует.