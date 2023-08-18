//
//  ContentView.swift
//  SamplePluginApp
//
//  Created by Sonoyama Yuto on 2023/08/17.
//

import SwiftUI
import SamplePlugin

struct ContentView: View {
    @State var number = 0
    
    var body: some View {
        VStack {
            Text("\(number)")
                .font(.largeTitle)
                .fontWeight(.bold)
                .foregroundColor(.accentColor)


            Button(action: {
                number = Int(sample_plugin_helloworld())
            }) {
                Text("Tap me!")
                    .font(.title)
                    .fontWeight(.bold)
                    .foregroundColor(.white)
                    .padding()
                    .background(Color.accentColor)
                    .cornerRadius(10)
            }
        }
        .padding()
    }
}
