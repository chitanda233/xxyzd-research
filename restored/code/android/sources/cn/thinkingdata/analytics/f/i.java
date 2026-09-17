package cn.thinkingdata.analytics.f;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public class i extends SharedPreferencesStorage<String> {
    public i(Future<SharedPreferences> future) {
        super(future, "identifyID");
    }
}
