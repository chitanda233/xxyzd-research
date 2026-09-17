package com.gorilla.privacystartup;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.text.method.LinkMovementMethod;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

/* JADX INFO: loaded from: classes3.dex */
public final class PrivacyStartupActivity extends Activity {
    private static final String CONSENT_KEY = "privacy_consent";
    private static final String PREFS = "gorilla_privacy_startup";
    private static final String TAG = "PrivacyStartup";
    private static final String UNITY_ACTIVITY = "com.unity3d.player.DxxUnityActivity";

    @Override // android.app.Activity
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        Log.i(TAG, "Privacy startup activity created");
        if (getSharedPreferences(PREFS, 0).getBoolean(CONSENT_KEY, false)) {
            Log.i(TAG, "Privacy consent already exists; launching Unity");
            launchUnity();
            return;
        }
        Log.i(TAG, "Current privacy consent is missing; showing privacy page");
        setContentView(R.layout.privacy_startup_page);
        ((TextView) findViewById(R.id.privacy_body)).setMovementMethod(LinkMovementMethod.getInstance());
        ((Button) findViewById(R.id.privacy_agree)).setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.privacystartup.PrivacyStartupActivity$$ExternalSyntheticLambda0
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m165xc7b12165(view);
            }
        });
        ((Button) findViewById(R.id.privacy_reject)).setOnClickListener(new View.OnClickListener() { // from class: com.gorilla.privacystartup.PrivacyStartupActivity$$ExternalSyntheticLambda1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.m166xb3c3f26(view);
            }
        });
    }

    /* JADX INFO: renamed from: lambda$onCreate$0$com-gorilla-privacystartup-PrivacyStartupActivity, reason: not valid java name */
    /* synthetic */ void m165xc7b12165(View view) {
        getSharedPreferences(PREFS, 0).edit().putBoolean(CONSENT_KEY, true).apply();
        Log.i(TAG, "Privacy consent accepted");
        launchUnity();
    }

    /* JADX INFO: renamed from: lambda$onCreate$1$com-gorilla-privacystartup-PrivacyStartupActivity, reason: not valid java name */
    /* synthetic */ void m166xb3c3f26(View view) {
        Log.i(TAG, "Privacy consent rejected; exiting application");
        finishAndRemoveTask();
    }

    private void launchUnity() {
        Intent intent = getIntent();
        Intent intent2 = new Intent(this, classForName(UNITY_ACTIVITY));
        intent2.setAction(intent.getAction());
        intent2.setData(intent.getData());
        intent2.setClipData(intent.getClipData());
        if (intent.getExtras() != null) {
            intent2.putExtras(intent.getExtras());
        }
        Log.i(TAG, "Launching Unity activity");
        startActivity(intent2);
        finish();
    }

    private static Class<?> classForName(String str) {
        try {
            return Class.forName(str);
        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        }
    }

    @Override // android.app.Activity
    public void onBackPressed() {
        Log.i(TAG, "Back pressed before privacy consent; exiting application");
        finishAndRemoveTask();
    }
}
