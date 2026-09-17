package com.gorilla.base;

import android.app.Activity;
import android.app.Application;
import android.os.Bundle;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;

/* JADX INFO: loaded from: classes3.dex */
public class ActivityLifecycleObserver implements Application.ActivityLifecycleCallbacks {
    public static final String TAG = "[ActivityLifecycleObserver]";
    private static final ILogger logger = LogFactory.getLogger();

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityCreated(Activity activity, Bundle bundle) {
        logger.log(TAG, "onActivityCreated: " + activity.getClass().getName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStarted(Activity activity) {
        logger.log(TAG, "onActivityStarted: " + activity.getClass().getName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityResumed(Activity activity) {
        logger.log(TAG, "onActivityResumed: " + activity.getClass().getName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityPaused(Activity activity) {
        logger.log(TAG, "onActivityPaused: " + activity.getClass().getName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStopped(Activity activity) {
        logger.log(TAG, "onActivityStopped: " + activity.getClass().getName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
        logger.log(TAG, "onActivitySaveInstanceState: " + activity.getClass().getName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityDestroyed(Activity activity) {
        logger.log(TAG, "onActivityDestroyed: " + activity.getClass().getName());
    }
}
