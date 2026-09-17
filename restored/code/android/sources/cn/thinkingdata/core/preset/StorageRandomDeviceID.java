package cn.thinkingdata.core.preset;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public class StorageRandomDeviceID extends SharedPreferencesStorage<String> {
    public StorageRandomDeviceID(Future<SharedPreferences> future) {
        super(future, "randomDeviceID");
    }

    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public String create() {
        return TDPresetUtils.getRandomHEXValue(16);
    }

    /* JADX WARN: Type inference failed for: r3v1, types: [T, java.lang.String] */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public void load(SharedPreferences sharedPreferences) {
        this.data = sharedPreferences.getString(this.storageKey, "");
    }

    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public void save(SharedPreferences.Editor editor, String str) {
        editor.putString(this.storageKey, str);
        editor.apply();
    }
}
