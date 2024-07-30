from antlr4 import *
from gen.JavaLexer import JavaLexer
from gen.JavaParserLabeled import JavaParserLabeled
from metric import DSCmetric
import argparse
import json
################################################################
def main(args,addr):
    stream = FileStream(args.file, encoding='utf8')
    lexer =JavaLexer(stream)
    token_stream = CommonTokenStream(lexer)
    parser = JavaParserLabeled(token_stream)
    parse_tree = parser.compilationUnit()
    my_listener = DSCmetric()
    walker = ParseTreeWalker()
    walker.walk(t=parse_tree, listener=my_listener)
################################################################
    methods_name = my_listener.get_name
    value = {
        "package_name": addr,
        "methods": methods_name
    }
    print("name of Methods:")
    print(json.dumps(value))
#################################################################
    attribute_of_each_class = my_listener.attributes_of_each_class
    value = {
        "package_name": addr ,
        "attributes of each class" : attribute_of_each_class

    }
    print("attributes of each class:")
    print(json.dumps(value))
##################################################################
if __name__ == '__main__':
    addr = str(input("Enter address of .java file:"))
    argparser = argparse.ArgumentParser()
    argparser.add_argument(
        '-n', '--file',
        help='Input source', default=addr)
    args = argparser.parse_args()
    main(args, addr)
