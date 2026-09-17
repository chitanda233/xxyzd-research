package com.sigmob.windad;

import com.sigmob.sdk.base.utils.s;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public class WindAdOptions {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3703a;
    private String b;
    private HashMap<String, String> c;
    private WindCustomController d;

    public WindAdOptions(String appId, String appKey) {
        if (s.b(appId)) {
            this.f3703a = appId.trim();
        }
        this.b = appKey;
    }

    public String getAppId() {
        return this.f3703a;
    }

    public String getAppKey() {
        return this.b;
    }

    public WindCustomController getCustomController() {
        return this.d;
    }

    public HashMap<String, String> getExtData() {
        return this.c;
    }

    public WindAdOptions setCustomController(WindCustomController customController) {
        this.d = customController;
        return this;
    }

    public WindAdOptions setExtData(HashMap<String, String> extData) {
        this.c = extData;
        return this;
    }
}
