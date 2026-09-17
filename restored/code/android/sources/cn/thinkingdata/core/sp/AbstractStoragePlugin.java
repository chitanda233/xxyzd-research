package cn.thinkingdata.core.sp;

import android.content.Context;
import android.content.SharedPreferences;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public abstract class AbstractStoragePlugin implements StoragePlugin {
    protected SharedPreferencesLoader sPrefsLoader;
    protected Future<SharedPreferences> storedSharedPrefs;

    public AbstractStoragePlugin(Context context, String str) {
        SharedPreferencesLoader sharedPreferencesLoader = new SharedPreferencesLoader();
        this.sPrefsLoader = sharedPreferencesLoader;
        this.storedSharedPrefs = sharedPreferencesLoader.loadPreferences(context, str);
        createStorage(context);
    }

    protected abstract void createStorage(Context context);

    @Override // cn.thinkingdata.core.sp.StoragePlugin
    public <T> T get(int i) {
        SharedPreferencesStorage<T> sharePreferenceStorage = getSharePreferenceStorage(i);
        if (sharePreferenceStorage != null) {
            return sharePreferenceStorage.get();
        }
        return null;
    }

    protected abstract <T> SharedPreferencesStorage<T> getSharePreferenceStorage(int i);

    @Override // cn.thinkingdata.core.sp.StoragePlugin
    public <T> void save(int i, T t) {
        SharedPreferencesStorage<T> sharePreferenceStorage = getSharePreferenceStorage(i);
        if (sharePreferenceStorage != null) {
            sharePreferenceStorage.put(t);
        }
    }
}
