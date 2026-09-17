package com.gorilla.base.plugin;

import android.app.Activity;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class GorillaPlugin {
    public Activity activity;
    public JSONObject args;
    public boolean isInit = false;
    public ILogger logger = LogFactory.getLogger();

    public abstract String getVersion();

    public void init(Activity activity, JSONObject jSONObject) {
        if (this.isInit) {
            return;
        }
        this.activity = activity;
        this.args = jSONObject;
        this.isInit = true;
    }
}
