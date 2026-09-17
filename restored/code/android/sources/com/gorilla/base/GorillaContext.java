package com.gorilla.base;

import android.app.Activity;
import com.gorilla.base.service.SharePreferenceService;

/* JADX INFO: loaded from: classes3.dex */
public class GorillaContext {
    private static GorillaContext instance;
    private final Activity activity;
    private final SharePreferenceService spService;

    public static synchronized void init(Activity activity) {
        if (instance == null) {
            instance = new GorillaContext(activity);
        }
    }

    public static GorillaContext getInstance() {
        return instance;
    }

    private GorillaContext(Activity activity) {
        this.activity = activity;
        this.spService = new SharePreferenceService(activity);
    }

    public Activity getActivity() {
        return this.activity;
    }

    public SharePreferenceService getSharePreference() {
        return this.spService;
    }
}
