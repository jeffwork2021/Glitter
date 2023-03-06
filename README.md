# 🗻 Glitter

Named after the second largest mountain in Norway, Glitter is a simple framework for encapsulating functionality to keep implementations clean, concise, and optimized.

![License](https://img.shields.io/github/license/tacosontitan/Glitter?logo=github&style=for-the-badge)

## 💁‍♀️ Getting Started

Get started by reviewing the answers to the following questions:

- [How do I navigate the codebase with confidence?](http://glitter.tacosontitan.com)
- [How can I help?](./CONTRIBUTING.md)
- [How should I behave here?](./CODE_OF_CONDUCT.md)
- [How do I report security concerns?](./SECURITY.md)

### ✅ Small changes, continuously integrated

Glitter employs workflows for continuous integration to ensure the repository is held to industry standards; here's the current state of those workflows:

![.NET Workflow](https://img.shields.io/github/actions/workflow/status/tacosontitan/Glitter/dotnet.yml?label=Build%20and%20Test&logo=dotnet&style=for-the-badge)

### 💎 A few more gems

We believe in keeping the community informed, so here's a few more tidbits of information to satisfy some additional curiosities:

![Contributors](https://img.shields.io/github/contributors/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Issues](https://img.shields.io/github/issues/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Stars](https://img.shields.io/github/stars/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Size](https://img.shields.io/github/languages/code-size/tacosontitan/Glitter?logo=github&style=for-the-badge)
![Line Count](https://img.shields.io/tokei/lines/github/tacosontitan/Glitter?logo=github&style=for-the-badge)

## 💠 Pipelines

Glitter offers a way to encapsulate the chain of responsibility pattern in a way that is easy to understand and maintain through what we call a pipeline. A pipeline is a collection of processors that are executed in order, and each processor can choose to handle the request or pass it on to the next processor in the chain. This allows for a clean separation of concerns, and the ability to easily add or remove processors from the pipeline.

```csharp
IPipeline<int> fizzBuzzPipeline = Pipeline.CreateFor<int>(optimize: true)
    .Using(new FizzBuzzProcessor())
    .Using(new FizzProcessor())
    .Using(new BuzzProcessor())
    .Using(new DefaultProcessor());

foreach (int number in Enumerable.Range(1, 100))
    await fizzBuzzPipeline.Process(number);
```
