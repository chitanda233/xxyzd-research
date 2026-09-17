package cn.thinkingdata.analytics.f;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.UUID;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public class n extends SharedPreferencesStorage<String> {
    public n(Future<SharedPreferences> future) {
        super(future, "randomID");
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public String create() {
        return UUID.randomUUID().toString();
    }
}
