package cn.thinkingdata.core.network;

/* JADX INFO: loaded from: classes.dex */
public interface Call {

    public interface Factory {
        Call newCall(Request request);
    }

    void enqueue(TEHttpCallback tEHttpCallback);

    TDNetResponse execute();
}
