from gen.JavaParserLabeled import JavaParserLabeled
from gen.JavaParserLabeledListener import JavaParserLabeledListener
import json
class DSCmetric(JavaParserLabeledListener):
    def __init__(self):
        self.__dsc = 0
        self.methods = list()
        self.attributes =dict()

    @property
    def get_design_size(self):
        return self.__dsc

    @property
    def get_name(self):
        return self.methods

    @property
    def attributes_of_each_class(self):
        return self.attributes


    def enterClassDeclaration(self, ctx: JavaParserLabeled.ClassDeclarationContext):
        self.__dsc += 1

    def enterMethodDeclaration(self, ctx: JavaParserLabeled.MethodDeclarationContext):
        self.methods.append(ctx.IDENTIFIER().getText())

    def enterFieldDeclaration(self, ctx:JavaParserLabeled.FieldDeclarationContext):
        x=ctx.parentCtx
        while(True):
            if(type(x) == JavaParserLabeled.ClassDeclarationContext):
                break
            x = x.parentCtx
        if (x.IDENTIFIER().getText() in self.attributes):
            self.attributes[x.IDENTIFIER().getText()] = self.__dsc + 1
        if (not x.IDENTIFIER().getText() in self.attributes):
            self.attributes[x.IDENTIFIER().getText()] = self.__dsc


