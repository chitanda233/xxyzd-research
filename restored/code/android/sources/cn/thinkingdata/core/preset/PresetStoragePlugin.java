package cn.thinkingdata.core.preset;

import android.content.Context;
import cn.thinkingdata.core.sp.AbstractStoragePlugin;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;

/* JADX INFO: loaded from: classes.dex */
public class PresetStoragePlugin extends AbstractStoragePlugin {
    public static final int DEVICE_ID = 100;
    private static final String PREFERENCE_NAME = "com.thinkingdata.analyse";
    private StorageRandomDeviceID randomDeviceID;

    public PresetStoragePlugin(Context context) {
        super(context, PREFERENCE_NAME);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected void createStorage(Context context) {
        this.randomDeviceID = new StorageRandomDeviceID(this.storedSharedPrefs);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected <T> SharedPreferencesStorage<T> getSharePreferenceStorage(int i) {
        if (i != 100) {
            return null;
        }
        return this.randomDeviceID;
    }
}
