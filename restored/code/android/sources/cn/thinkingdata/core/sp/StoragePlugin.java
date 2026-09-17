package cn.thinkingdata.core.sp;

/* JADX INFO: loaded from: classes.dex */
public interface StoragePlugin {
    <T> T get(int i);

    <T> void save(int i, T t);
}
